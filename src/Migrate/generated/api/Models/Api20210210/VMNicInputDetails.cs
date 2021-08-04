namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Hyper V VM network input details.</summary>
    public partial class VMNicInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicInputDetailsInternal
    {

        /// <summary>
        /// Backing field for <see cref="EnableAcceleratedNetworkingOnRecovery" /> property.
        /// </summary>
        private bool? _enableAcceleratedNetworkingOnRecovery;

        /// <summary>Whether the NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworkingOnRecovery { get => this._enableAcceleratedNetworkingOnRecovery; set => this._enableAcceleratedNetworkingOnRecovery = value; }

        /// <summary>Backing field for <see cref="EnableAcceleratedNetworkingOnTfo" /> property.</summary>
        private bool? _enableAcceleratedNetworkingOnTfo;

        /// <summary>Whether the test NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworkingOnTfo { get => this._enableAcceleratedNetworkingOnTfo; set => this._enableAcceleratedNetworkingOnTfo = value; }

        /// <summary>Backing field for <see cref="IPConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails[] _iPConfig;

        /// <summary>The IP configurations to be used by NIC during test failover and failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails[] IPConfig { get => this._iPConfig; set => this._iPConfig = value; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>The nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; set => this._nicId = value; }

        /// <summary>Backing field for <see cref="RecoveryNetworkSecurityGroupId" /> property.</summary>
        private string _recoveryNetworkSecurityGroupId;

        /// <summary>The id of the NSG associated with the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryNetworkSecurityGroupId { get => this._recoveryNetworkSecurityGroupId; set => this._recoveryNetworkSecurityGroupId = value; }

        /// <summary>Backing field for <see cref="RecoveryNicName" /> property.</summary>
        private string _recoveryNicName;

        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryNicName { get => this._recoveryNicName; set => this._recoveryNicName = value; }

        /// <summary>Backing field for <see cref="RecoveryNicResourceGroupName" /> property.</summary>
        private string _recoveryNicResourceGroupName;

        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryNicResourceGroupName { get => this._recoveryNicResourceGroupName; set => this._recoveryNicResourceGroupName = value; }

        /// <summary>Backing field for <see cref="ReuseExistingNic" /> property.</summary>
        private bool? _reuseExistingNic;

        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? ReuseExistingNic { get => this._reuseExistingNic; set => this._reuseExistingNic = value; }

        /// <summary>Backing field for <see cref="SelectionType" /> property.</summary>
        private string _selectionType;

        /// <summary>Selection type for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SelectionType { get => this._selectionType; set => this._selectionType = value; }

        /// <summary>Backing field for <see cref="TfoNetworkSecurityGroupId" /> property.</summary>
        private string _tfoNetworkSecurityGroupId;

        /// <summary>The NSG to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoNetworkSecurityGroupId { get => this._tfoNetworkSecurityGroupId; set => this._tfoNetworkSecurityGroupId = value; }

        /// <summary>Backing field for <see cref="TfoNicName" /> property.</summary>
        private string _tfoNicName;

        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoNicName { get => this._tfoNicName; set => this._tfoNicName = value; }

        /// <summary>Backing field for <see cref="TfoNicResourceGroupName" /> property.</summary>
        private string _tfoNicResourceGroupName;

        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoNicResourceGroupName { get => this._tfoNicResourceGroupName; set => this._tfoNicResourceGroupName = value; }

        /// <summary>Backing field for <see cref="TfoReuseExistingNic" /> property.</summary>
        private bool? _tfoReuseExistingNic;

        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? TfoReuseExistingNic { get => this._tfoReuseExistingNic; set => this._tfoReuseExistingNic = value; }

        /// <summary>Creates an new <see cref="VMNicInputDetails" /> instance.</summary>
        public VMNicInputDetails()
        {

        }
    }
    /// Hyper V VM network input details.
    public partial interface IVMNicInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Whether the NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the NIC has accelerated networking enabled.",
        SerializedName = @"enableAcceleratedNetworkingOnRecovery",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworkingOnRecovery { get; set; }
        /// <summary>Whether the test NIC has accelerated networking enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the test NIC has accelerated networking enabled.",
        SerializedName = @"enableAcceleratedNetworkingOnTfo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworkingOnTfo { get; set; }
        /// <summary>The IP configurations to be used by NIC during test failover and failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP configurations to be used by NIC during test failover and failover.",
        SerializedName = @"ipConfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails[] IPConfig { get; set; }
        /// <summary>The nic Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The nic Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get; set; }
        /// <summary>The id of the NSG associated with the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the NSG associated with the NIC.",
        SerializedName = @"recoveryNetworkSecurityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NIC to be used when creating target NICs.",
        SerializedName = @"recoveryNicName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group of the NIC to be used when creating target NICs.",
        SerializedName = @"recoveryNicResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.",
        SerializedName = @"reuseExistingNic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReuseExistingNic { get; set; }
        /// <summary>Selection type for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Selection type for failover.",
        SerializedName = @"selectionType",
        PossibleTypes = new [] { typeof(string) })]
        string SelectionType { get; set; }
        /// <summary>The NSG to be used by NIC during test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The NSG to be used by NIC during test failover.",
        SerializedName = @"tfoNetworkSecurityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TfoNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the NIC to be used when creating target NICs in TFO.",
        SerializedName = @"tfoNicName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group of the NIC to be used when creating target NICs in TFO.",
        SerializedName = @"tfoNicResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.",
        SerializedName = @"tfoReuseExistingNic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TfoReuseExistingNic { get; set; }

    }
    /// Hyper V VM network input details.
    internal partial interface IVMNicInputDetailsInternal

    {
        /// <summary>Whether the NIC has accelerated networking enabled.</summary>
        bool? EnableAcceleratedNetworkingOnRecovery { get; set; }
        /// <summary>Whether the test NIC has accelerated networking enabled.</summary>
        bool? EnableAcceleratedNetworkingOnTfo { get; set; }
        /// <summary>The IP configurations to be used by NIC during test failover and failover.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails[] IPConfig { get; set; }
        /// <summary>The nic Id.</summary>
        string NicId { get; set; }
        /// <summary>The id of the NSG associated with the NIC.</summary>
        string RecoveryNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs.</summary>
        string RecoveryNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs.</summary>
        string RecoveryNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during failover subject to availability.
        /// </summary>
        bool? ReuseExistingNic { get; set; }
        /// <summary>Selection type for failover.</summary>
        string SelectionType { get; set; }
        /// <summary>The NSG to be used by NIC during test failover.</summary>
        string TfoNetworkSecurityGroupId { get; set; }
        /// <summary>The name of the NIC to be used when creating target NICs in TFO.</summary>
        string TfoNicName { get; set; }
        /// <summary>The resource group of the NIC to be used when creating target NICs in TFO.</summary>
        string TfoNicResourceGroupName { get; set; }
        /// <summary>
        /// A value indicating whether an existing NIC is allowed to be reused during test failover subject to availability.
        /// </summary>
        bool? TfoReuseExistingNic { get; set; }

    }
}