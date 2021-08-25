
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for TransferConfiguration
.Description
Create a in-memory object for TransferConfiguration
.Example
PS C:\>  $transferConfigurationType = New-AzDataBoxTransferConfigurationObject -Type "TransferAll" -TransferAllDetail @{"IncludeDataAccountType"="StorageAccount";"IncludeTransferAllBlob"= "True"; "IncludeTransferAllFile"="True"}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfiguration
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

TRANSFERALLDETAIL <ITransferConfigurationTransferAllDetails>: Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType is given as TransferAll.
  [IncludeDataAccountType <DataAccountType?>]: Type of the account of data
  [IncludeTransferAllBlob <Boolean?>]: To indicate if all Azure blobs have to be transferred
  [IncludeTransferAllFile <Boolean?>]: To indicate if all Azure Files have to be transferred

TRANSFERFILTERDETAIL <ITransferConfigurationTransferFilterDetails>: Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as TransferUsingFilter.
  [AzureFileFilterDetailFilePathList <String[]>]: List of full path of the files to be transferred.
  [AzureFileFilterDetailFilePrefixList <String[]>]: Prefix list of the Azure files to be transferred.
  [AzureFileFilterDetailFileShareList <String[]>]: List of file shares to be transferred.
  [BlobFilterDetailBlobPathList <String[]>]: List of full path of the blobs to be transferred.
  [BlobFilterDetailBlobPrefixList <String[]>]: Prefix list of the Azure blobs to be transferred.
  [BlobFilterDetailContainerList <String[]>]: List of blob containers to be transferred.
  [IncludeDataAccountType <DataAccountType?>]: Type of the account of data.
  [IncludeFilterFileDetail <IFilterFileDetails[]>]: Details of the filter files to be used for data transfer.
    FilterFilePath <String>: Path of the file that contains the details of all items to transfer.
    FilterFileType <FilterFileType>: Type of the filter file.
.Link
https://docs.microsoft.com/powershell/module/az.DataBox/new-AzDataBoxTransferConfigurationObject
#>
function New-AzDataBoxTransferConfigurationObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.TransferConfiguration])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.TransferConfigurationType]
    # Type of the configuration for transfer.
    ${Type},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferAllDetails]
    # Map of filter type and the details to transfer all data.
    # This field is required only if the TransferConfigurationType is given as TransferAll.
    # To construct, see NOTES section for TRANSFERALLDETAIL properties and create a hash table.
    ${TransferAllDetail},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ITransferConfigurationTransferFilterDetails]
    # Map of filter type and the details to filter.
    # This field is required only if the TransferConfigurationType is given as TransferUsingFilter.
    # To construct, see NOTES section for TRANSFERFILTERDETAIL properties and create a hash table.
    ${TransferFilterDetail}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.DataBox.custom\New-AzDataBoxTransferConfigurationObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
