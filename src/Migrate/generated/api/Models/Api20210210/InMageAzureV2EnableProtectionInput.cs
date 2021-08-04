namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMware Azure specific enable protection input.</summary>
    public partial class InMageAzureV2EnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput __enableProtectionProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EnableProtectionProviderSpecificInput();

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? _diskType;

        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="DisksToInclude" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[] _disksToInclude;

        /// <summary>The disks to include list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[] DisksToInclude { get => this._disksToInclude; set => this._disksToInclude = value; }

        /// <summary>Backing field for <see cref="EnableRdpOnTargetOption" /> property.</summary>
        private string _enableRdpOnTargetOption;

        /// <summary>
        /// The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EnableRdpOnTargetOption { get => this._enableRdpOnTargetOption; set => this._enableRdpOnTargetOption = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? _licenseType;

        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The storage account to be used for logging during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; set => this._logStorageAccountId = value; }

        /// <summary>Backing field for <see cref="MasterTargetId" /> property.</summary>
        private string _masterTargetId;

        /// <summary>The Master target Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MasterTargetId { get => this._masterTargetId; set => this._masterTargetId = value; }

        /// <summary>Backing field for <see cref="MultiVMGroupId" /> property.</summary>
        private string _multiVMGroupId;

        /// <summary>The multi VM group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupId { get => this._multiVMGroupId; set => this._multiVMGroupId = value; }

        /// <summary>Backing field for <see cref="MultiVMGroupName" /> property.</summary>
        private string _multiVMGroupName;

        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupName { get => this._multiVMGroupName; set => this._multiVMGroupName = value; }

        /// <summary>Backing field for <see cref="ProcessServerId" /> property.</summary>
        private string _processServerId;

        /// <summary>The Process Server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProcessServerId { get => this._processServerId; set => this._processServerId = value; }

        /// <summary>Backing field for <see cref="RunAsAccountId" /> property.</summary>
        private string _runAsAccountId;

        /// <summary>The CS account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RunAsAccountId { get => this._runAsAccountId; set => this._runAsAccountId = value; }

        /// <summary>Backing field for <see cref="SeedManagedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags _seedManagedDiskTag;

        /// <summary>The tags for the seed managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get => (this._seedManagedDiskTag = this._seedManagedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputSeedManagedDiskTags()); set => this._seedManagedDiskTag = value; }

        /// <summary>Backing field for <see cref="SqlServerLicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? _sqlServerLicenseType;

        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get => this._sqlServerLicenseType; set => this._sqlServerLicenseType = value; }

        /// <summary>Backing field for <see cref="StorageAccountId" /> property.</summary>
        private string _storageAccountId;

        /// <summary>The storage account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string StorageAccountId { get => this._storageAccountId; set => this._storageAccountId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilitySetId" /> property.</summary>
        private string _targetAvailabilitySetId;

        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilitySetId { get => this._targetAvailabilitySetId; set => this._targetAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="TargetAzureNetworkId" /> property.</summary>
        private string _targetAzureNetworkId;

        /// <summary>The selected target Azure network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureNetworkId { get => this._targetAzureNetworkId; set => this._targetAzureNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetAzureSubnetId" /> property.</summary>
        private string _targetAzureSubnetId;

        /// <summary>The selected target Azure subnet Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureSubnetId { get => this._targetAzureSubnetId; set => this._targetAzureSubnetId = value; }

        /// <summary>Backing field for <see cref="TargetAzureV1ResourceGroupId" /> property.</summary>
        private string _targetAzureV1ResourceGroupId;

        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureV1ResourceGroupId { get => this._targetAzureV1ResourceGroupId; set => this._targetAzureV1ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetAzureV2ResourceGroupId" /> property.</summary>
        private string _targetAzureV2ResourceGroupId;

        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureV2ResourceGroupId { get => this._targetAzureV2ResourceGroupId; set => this._targetAzureV2ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetAzureVMName" /> property.</summary>
        private string _targetAzureVMName;

        /// <summary>The target azure VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureVMName { get => this._targetAzureVMName; set => this._targetAzureVMName = value; }

        /// <summary>Backing field for <see cref="TargetManagedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags _targetManagedDiskTag;

        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get => (this._targetManagedDiskTag = this._targetManagedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetManagedDiskTags()); set => this._targetManagedDiskTag = value; }

        /// <summary>Backing field for <see cref="TargetNicTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags _targetNicTag;

        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags TargetNicTag { get => (this._targetNicTag = this._targetNicTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetNicTags()); set => this._targetNicTag = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetVMSize" /> property.</summary>
        private string _targetVMSize;

        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMSize { get => this._targetVMSize; set => this._targetVMSize = value; }

        /// <summary>Backing field for <see cref="TargetVMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags _targetVMTag;

        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags TargetVMTag { get => (this._targetVMTag = this._targetVMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2EnableProtectionInputTargetVMTags()); set => this._targetVMTag = value; }

        /// <summary>Creates an new <see cref="InMageAzureV2EnableProtectionInput" /> instance.</summary>
        public InMageAzureV2EnableProtectionInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
        }
    }
    /// VMware Azure specific enable protection input.
    public partial interface IInMageAzureV2EnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput
    {
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskEncryptionSet ARM Id.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskType.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The disks to include list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disks to include list.",
        SerializedName = @"disksToInclude",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[] DisksToInclude { get; set; }
        /// <summary>
        /// The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum.",
        SerializedName = @"enableRdpOnTargetOption",
        PossibleTypes = new [] { typeof(string) })]
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License type.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The storage account to be used for logging during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage account to be used for logging during replication.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get; set; }
        /// <summary>The Master target Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Master target Id.",
        SerializedName = @"masterTargetId",
        PossibleTypes = new [] { typeof(string) })]
        string MasterTargetId { get; set; }
        /// <summary>The multi VM group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi VM group Id.",
        SerializedName = @"multiVmGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupId { get; set; }
        /// <summary>The multi VM group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi VM group name.",
        SerializedName = @"multiVmGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupName { get; set; }
        /// <summary>The Process Server Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Process Server Id.",
        SerializedName = @"processServerId",
        PossibleTypes = new [] { typeof(string) })]
        string ProcessServerId { get; set; }
        /// <summary>The CS account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The CS account Id.",
        SerializedName = @"runAsAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RunAsAccountId { get; set; }
        /// <summary>The tags for the seed managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the seed managed disks.",
        SerializedName = @"seedManagedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get; set; }
        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL Server license type.",
        SerializedName = @"sqlServerLicenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The storage account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage account Id.",
        SerializedName = @"storageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountId { get; set; }
        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set ARM Id for resource manager deployment.",
        SerializedName = @"targetAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The selected target Azure network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected target Azure network Id.",
        SerializedName = @"targetAzureNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureNetworkId { get; set; }
        /// <summary>The selected target Azure subnet Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected target Azure subnet Id.",
        SerializedName = @"targetAzureSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureSubnetId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the target resource group (for classic deployment) in which the failover VM is to be created.",
        SerializedName = @"targetAzureV1ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureV1ResourceGroupId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.",
        SerializedName = @"targetAzureV2ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureV2ResourceGroupId { get; set; }
        /// <summary>The target azure VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target azure VM Name.",
        SerializedName = @"targetAzureVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureVMName { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target managed disks.",
        SerializedName = @"targetManagedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target NICs.",
        SerializedName = @"targetNicTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The proximity placement group ARM Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM size.",
        SerializedName = @"targetVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM tags.",
        SerializedName = @"targetVmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags TargetVMTag { get; set; }

    }
    /// VMware Azure specific enable protection input.
    internal partial interface IInMageAzureV2EnableProtectionInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal
    {
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskType.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The disks to include list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2DiskInputDetails[] DisksToInclude { get; set; }
        /// <summary>
        /// The selected option to enable RDP\SSH on target VM after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>License type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The storage account to be used for logging during replication.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The Master target Id.</summary>
        string MasterTargetId { get; set; }
        /// <summary>The multi VM group Id.</summary>
        string MultiVMGroupId { get; set; }
        /// <summary>The multi VM group name.</summary>
        string MultiVMGroupName { get; set; }
        /// <summary>The Process Server Id.</summary>
        string ProcessServerId { get; set; }
        /// <summary>The CS account Id.</summary>
        string RunAsAccountId { get; set; }
        /// <summary>The tags for the seed managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get; set; }
        /// <summary>The SQL Server license type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The storage account Id.</summary>
        string StorageAccountId { get; set; }
        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The selected target Azure network Id.</summary>
        string TargetAzureNetworkId { get; set; }
        /// <summary>The selected target Azure subnet Id.</summary>
        string TargetAzureSubnetId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        string TargetAzureV1ResourceGroupId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        string TargetAzureV2ResourceGroupId { get; set; }
        /// <summary>The target azure VM Name.</summary>
        string TargetAzureVMName { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The proximity placement group ARM Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2EnableProtectionInputTargetVMTags TargetVMTag { get; set; }

    }
}