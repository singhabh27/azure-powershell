function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id

    $str1 = RandomString -allChars $false -len 6

    $appStoreName1 = "az" + (RandomString -allChars $false -len 4)
    $env.Add("appStoreName1", $appStoreName1)

    $appStoreName2 = "az" + (RandomString -allChars $false -len 4)
    $env.Add("appStoreName2", $appStoreName2)

    $env.Add("location", "eastus")

    write-host "start to create test group"
    $resourceGroup = "azpstestgroup-" + $str1
    $env.Add("resourceGroup", $resourceGroup)
    New-AzResourceGroup -Name $env.resourceGroup -Location $env.location
    $configurationStore = New-AzAppConfigurationStore -Name $env.appStoreName1 -ResourceGroupName $env.resourceGroup -Location $env.location
    $env.Add("endpoint", $configurationStore.Endpoint)
    $loginObjectId = (Get-AzContext).Account.ExtendedProperties['HomeAccountId']
    New-AzRoleAssignment -ObjectId $loginObjectId -RoleDefinitionName "App Configuration Data Owner" -Scope $configurationStore.Id
    $key = (RandomString -allChars $false -len 4)
    $value = (RandomString -allChars $false -len 16)
    Set-AzAppConfigurationKeyValue -Endpoint $configurationStore.Endpoint -Key $key -Value $value -Label "test"
    $env.Add("key", $key)

    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
}

