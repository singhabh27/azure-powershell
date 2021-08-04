namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A enable protection input.</summary>
    public partial class A2AEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput __enableProtectionProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EnableProtectionProviderSpecificInput();

        /// <summary>Backing field for <see cref="DiskEncryptionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo _diskEncryptionInfo;

        /// <summary>The recovery disk encryption information (for two pass flows).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfo()); set => this._diskEncryptionInfo = value; }

        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DiskEncryptionKeyInfoSecretIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfoSecretIdentifier = value ?? null; }

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; set => this._fabricObjectId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyIdentifier = value ?? null; }

        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyInfoKeyVaultResourceArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfoKeyVaultResourceArmId = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal.DiskEncryptionInfo { get => (this._diskEncryptionInfo = this._diskEncryptionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfo()); set { {_diskEncryptionInfo = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionInfoDiskEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal.DiskEncryptionInfoDiskEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).DiskEncryptionKeyInfo = value; }

        /// <summary>Internal Acessors for DiskEncryptionInfoKeyEncryptionKeyInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AEnableProtectionInputInternal.DiskEncryptionInfoKeyEncryptionKeyInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfoInternal)DiskEncryptionInfo).KeyEncryptionKeyInfo = value; }

        /// <summary>Backing field for <see cref="MultiVMGroupId" /> property.</summary>
        private string _multiVMGroupId;

        /// <summary>The multi vm group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupId { get => this._multiVMGroupId; set => this._multiVMGroupId = value; }

        /// <summary>Backing field for <see cref="MultiVMGroupName" /> property.</summary>
        private string _multiVMGroupName;

        /// <summary>The multi vm group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MultiVMGroupName { get => this._multiVMGroupName; set => this._multiVMGroupName = value; }

        /// <summary>Backing field for <see cref="RecoveryAvailabilitySetId" /> property.</summary>
        private string _recoveryAvailabilitySetId;

        /// <summary>The recovery availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAvailabilitySetId { get => this._recoveryAvailabilitySetId; set => this._recoveryAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="RecoveryAvailabilityZone" /> property.</summary>
        private string _recoveryAvailabilityZone;

        /// <summary>The recovery availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAvailabilityZone { get => this._recoveryAvailabilityZone; set => this._recoveryAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="RecoveryAzureNetworkId" /> property.</summary>
        private string _recoveryAzureNetworkId;

        /// <summary>The recovery Azure virtual network ARM id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryAzureNetworkId { get => this._recoveryAzureNetworkId; set => this._recoveryAzureNetworkId = value; }

        /// <summary>Backing field for <see cref="RecoveryBootDiagStorageAccountId" /> property.</summary>
        private string _recoveryBootDiagStorageAccountId;

        /// <summary>The boot diagnostic storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryBootDiagStorageAccountId { get => this._recoveryBootDiagStorageAccountId; set => this._recoveryBootDiagStorageAccountId = value; }

        /// <summary>Backing field for <see cref="RecoveryCloudServiceId" /> property.</summary>
        private string _recoveryCloudServiceId;

        /// <summary>The recovery cloud service Id. Valid for V1 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryCloudServiceId { get => this._recoveryCloudServiceId; set => this._recoveryCloudServiceId = value; }

        /// <summary>Backing field for <see cref="RecoveryContainerId" /> property.</summary>
        private string _recoveryContainerId;

        /// <summary>The recovery container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryContainerId { get => this._recoveryContainerId; set => this._recoveryContainerId = value; }

        /// <summary>Backing field for <see cref="RecoveryProximityPlacementGroupId" /> property.</summary>
        private string _recoveryProximityPlacementGroupId;

        /// <summary>The recovery proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryProximityPlacementGroupId { get => this._recoveryProximityPlacementGroupId; set => this._recoveryProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="RecoveryResourceGroupId" /> property.</summary>
        private string _recoveryResourceGroupId;

        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryResourceGroupId { get => this._recoveryResourceGroupId; set => this._recoveryResourceGroupId = value; }

        /// <summary>Backing field for <see cref="RecoverySubnetName" /> property.</summary>
        private string _recoverySubnetName;

        /// <summary>The recovery subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoverySubnetName { get => this._recoverySubnetName; set => this._recoverySubnetName = value; }

        /// <summary>Backing field for <see cref="RecoveryVirtualMachineScaleSetId" /> property.</summary>
        private string _recoveryVirtualMachineScaleSetId;

        /// <summary>The virtual machine scale set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryVirtualMachineScaleSetId { get => this._recoveryVirtualMachineScaleSetId; set => this._recoveryVirtualMachineScaleSetId = value; }

        /// <summary>Backing field for <see cref="VMDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[] _vMDisk;

        /// <summary>The list of vm disk details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[] VMDisk { get => this._vMDisk; set => this._vMDisk = value; }

        /// <summary>Backing field for <see cref="VMManagedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[] _vMManagedDisk;

        /// <summary>The list of vm managed disk details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[] VMManagedDisk { get => this._vMManagedDisk; set => this._vMManagedDisk = value; }

        /// <summary>Creates an new <see cref="A2AEnableProtectionInput" /> instance.</summary>
        public A2AEnableProtectionInput()
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
    /// A2A enable protection input.
    public partial interface IA2AEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInput
    {
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM id for secret.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secret url / identifier.",
        SerializedName = @"secretIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fabric specific object Id of the virtual machine.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The key URL / identifier.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The KeyVault resource ARM Id for key.",
        SerializedName = @"keyVaultResourceArmId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The multi vm group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi vm group id.",
        SerializedName = @"multiVmGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupId { get; set; }
        /// <summary>The multi vm group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The multi vm group name.",
        SerializedName = @"multiVmGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string MultiVMGroupName { get; set; }
        /// <summary>The recovery availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery availability set Id.",
        SerializedName = @"recoveryAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilitySetId { get; set; }
        /// <summary>The recovery availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery availability zone.",
        SerializedName = @"recoveryAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilityZone { get; set; }
        /// <summary>The recovery Azure virtual network ARM id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery Azure virtual network ARM id.",
        SerializedName = @"recoveryAzureNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureNetworkId { get; set; }
        /// <summary>The boot diagnostic storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The boot diagnostic storage account.",
        SerializedName = @"recoveryBootDiagStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryBootDiagStorageAccountId { get; set; }
        /// <summary>The recovery cloud service Id. Valid for V1 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery cloud service Id. Valid for V1 scenarios.",
        SerializedName = @"recoveryCloudServiceId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryCloudServiceId { get; set; }
        /// <summary>The recovery container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery container Id.",
        SerializedName = @"recoveryContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryContainerId { get; set; }
        /// <summary>The recovery proximity placement group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery proximity placement group Id.",
        SerializedName = @"recoveryProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryProximityPlacementGroupId { get; set; }
        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery resource group Id. Valid for V2 scenarios.",
        SerializedName = @"recoveryResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryResourceGroupId { get; set; }
        /// <summary>The recovery subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery subnet name.",
        SerializedName = @"recoverySubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoverySubnetName { get; set; }
        /// <summary>The virtual machine scale set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The virtual machine scale set Id.",
        SerializedName = @"recoveryVirtualMachineScaleSetId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVirtualMachineScaleSetId { get; set; }
        /// <summary>The list of vm disk details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm disk details.",
        SerializedName = @"vmDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[] VMDisk { get; set; }
        /// <summary>The list of vm managed disk details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of vm managed disk details.",
        SerializedName = @"vmManagedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[] VMManagedDisk { get; set; }

    }
    /// A2A enable protection input.
    internal partial interface IA2AEnableProtectionInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal
    {
        /// <summary>The recovery disk encryption information (for two pass flows).</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary>The recovery KeyVault reference for secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IDiskEncryptionKeyInfo DiskEncryptionInfoDiskEncryptionKeyInfo { get; set; }
        /// <summary>The recovery KeyVault reference for key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IKeyEncryptionKeyInfo DiskEncryptionInfoKeyEncryptionKeyInfo { get; set; }
        /// <summary>The KeyVault resource ARM id for secret.</summary>
        string DiskEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The secret url / identifier.</summary>
        string DiskEncryptionKeyInfoSecretIdentifier { get; set; }
        /// <summary>The fabric specific object Id of the virtual machine.</summary>
        string FabricObjectId { get; set; }
        /// <summary>The key URL / identifier.</summary>
        string KeyEncryptionKeyInfoKeyIdentifier { get; set; }
        /// <summary>The KeyVault resource ARM Id for key.</summary>
        string KeyEncryptionKeyInfoKeyVaultResourceArmId { get; set; }
        /// <summary>The multi vm group id.</summary>
        string MultiVMGroupId { get; set; }
        /// <summary>The multi vm group name.</summary>
        string MultiVMGroupName { get; set; }
        /// <summary>The recovery availability set Id.</summary>
        string RecoveryAvailabilitySetId { get; set; }
        /// <summary>The recovery availability zone.</summary>
        string RecoveryAvailabilityZone { get; set; }
        /// <summary>The recovery Azure virtual network ARM id.</summary>
        string RecoveryAzureNetworkId { get; set; }
        /// <summary>The boot diagnostic storage account.</summary>
        string RecoveryBootDiagStorageAccountId { get; set; }
        /// <summary>The recovery cloud service Id. Valid for V1 scenarios.</summary>
        string RecoveryCloudServiceId { get; set; }
        /// <summary>The recovery container Id.</summary>
        string RecoveryContainerId { get; set; }
        /// <summary>The recovery proximity placement group Id.</summary>
        string RecoveryProximityPlacementGroupId { get; set; }
        /// <summary>The recovery resource group Id. Valid for V2 scenarios.</summary>
        string RecoveryResourceGroupId { get; set; }
        /// <summary>The recovery subnet name.</summary>
        string RecoverySubnetName { get; set; }
        /// <summary>The virtual machine scale set Id.</summary>
        string RecoveryVirtualMachineScaleSetId { get; set; }
        /// <summary>The list of vm disk details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmDiskInputDetails[] VMDisk { get; set; }
        /// <summary>The list of vm managed disk details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AvmManagedDiskInputDetails[] VMManagedDisk { get; set; }

    }
}