namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm NIC input.</summary>
    public partial class InMageRcmNicInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicInputInternal
    {

        /// <summary>Backing field for <see cref="IsPrimaryNic" /> property.</summary>
        private string _isPrimaryNic;

        /// <summary>A value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsPrimaryNic { get => this._isPrimaryNic; set => this._isPrimaryNic = value; }

        /// <summary>Backing field for <see cref="IsSelectedForFailover" /> property.</summary>
        private string _isSelectedForFailover;

        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsSelectedForFailover { get => this._isSelectedForFailover; set => this._isSelectedForFailover = value; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>The NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; set => this._nicId = value; }

        /// <summary>Backing field for <see cref="TargetStaticIPAddress" /> property.</summary>
        private string _targetStaticIPAddress;

        /// <summary>The target static IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetStaticIPAddress { get => this._targetStaticIPAddress; set => this._targetStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="TargetSubnetName" /> property.</summary>
        private string _targetSubnetName;

        /// <summary>Target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetSubnetName { get => this._targetSubnetName; set => this._targetSubnetName = value; }

        /// <summary>Backing field for <see cref="TestStaticIPAddress" /> property.</summary>
        private string _testStaticIPAddress;

        /// <summary>The test static IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestStaticIPAddress { get => this._testStaticIPAddress; set => this._testStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="TestSubnetName" /> property.</summary>
        private string _testSubnetName;

        /// <summary>The test subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TestSubnetName { get => this._testSubnetName; set => this._testSubnetName = value; }

        /// <summary>Creates an new <see cref="InMageRcmNicInput" /> instance.</summary>
        public InMageRcmNicInput()
        {

        }
    }
    /// InMageRcm NIC input.
    public partial interface IInMageRcmNicInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A value indicating whether this is the primary NIC.",
        SerializedName = @"isPrimaryNic",
        PossibleTypes = new [] { typeof(string) })]
        string IsPrimaryNic { get; set; }
        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether this NIC is selected for failover.",
        SerializedName = @"isSelectedForFailover",
        PossibleTypes = new [] { typeof(string) })]
        string IsSelectedForFailover { get; set; }
        /// <summary>The NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The NIC Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get; set; }
        /// <summary>The target static IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target static IP address.",
        SerializedName = @"targetStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TargetStaticIPAddress { get; set; }
        /// <summary>Target subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target subnet name.",
        SerializedName = @"targetSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetSubnetName { get; set; }
        /// <summary>The test static IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test static IP address.",
        SerializedName = @"testStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TestStaticIPAddress { get; set; }
        /// <summary>The test subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The test subnet name.",
        SerializedName = @"testSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TestSubnetName { get; set; }

    }
    /// InMageRcm NIC input.
    internal partial interface IInMageRcmNicInputInternal

    {
        /// <summary>A value indicating whether this is the primary NIC.</summary>
        string IsPrimaryNic { get; set; }
        /// <summary>A value indicating whether this NIC is selected for failover.</summary>
        string IsSelectedForFailover { get; set; }
        /// <summary>The NIC Id.</summary>
        string NicId { get; set; }
        /// <summary>The target static IP address.</summary>
        string TargetStaticIPAddress { get; set; }
        /// <summary>Target subnet name.</summary>
        string TargetSubnetName { get; set; }
        /// <summary>The test static IP address.</summary>
        string TestStaticIPAddress { get; set; }
        /// <summary>The test subnet name.</summary>
        string TestSubnetName { get; set; }

    }
}