namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Query parameter to get fabric.</summary>
    public partial class FabricQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricQueryParameter,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricQueryParameterInternal
    {

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>The BIOS Id to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; set => this._biosId = value; }

        /// <summary>Backing field for <see cref="DiscoveryType" /> property.</summary>
        private string _discoveryType;

        /// <summary>The type of the discovered machine to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiscoveryType { get => this._discoveryType; set => this._discoveryType = value; }

        /// <summary>Backing field for <see cref="FetchAgentDetail" /> property.</summary>
        private string _fetchAgentDetail;

        /// <summary>A value indicating whether the agent details are to be fetched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FetchAgentDetail { get => this._fetchAgentDetail; set => this._fetchAgentDetail = value; }

        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>The FQDN to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Fqdn { get => this._fqdn; set => this._fqdn = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The OS type to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="ZoneToZoneMapping" /> property.</summary>
        private string _zoneToZoneMapping;

        /// <summary>A value indicating whether the zone to zone mappings are to be returned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ZoneToZoneMapping { get => this._zoneToZoneMapping; set => this._zoneToZoneMapping = value; }

        /// <summary>Creates an new <see cref="FabricQueryParameter" /> instance.</summary>
        public FabricQueryParameter()
        {

        }
    }
    /// Query parameter to get fabric.
    public partial interface IFabricQueryParameter :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The BIOS Id to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The BIOS Id to be used for fetching agent details.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>The type of the discovered machine to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the discovered machine to be used for fetching agent details.",
        SerializedName = @"discoveryType",
        PossibleTypes = new [] { typeof(string) })]
        string DiscoveryType { get; set; }
        /// <summary>A value indicating whether the agent details are to be fetched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the agent details are to be fetched.",
        SerializedName = @"fetchAgentDetails",
        PossibleTypes = new [] { typeof(string) })]
        string FetchAgentDetail { get; set; }
        /// <summary>The FQDN to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The FQDN to be used for fetching agent details.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string Fqdn { get; set; }
        /// <summary>The OS type to be used for fetching agent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OS type to be used for fetching agent details.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>A value indicating whether the zone to zone mappings are to be returned.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the zone to zone mappings are to be returned.",
        SerializedName = @"zoneToZoneMappings",
        PossibleTypes = new [] { typeof(string) })]
        string ZoneToZoneMapping { get; set; }

    }
    /// Query parameter to get fabric.
    internal partial interface IFabricQueryParameterInternal

    {
        /// <summary>The BIOS Id to be used for fetching agent details.</summary>
        string BiosId { get; set; }
        /// <summary>The type of the discovered machine to be used for fetching agent details.</summary>
        string DiscoveryType { get; set; }
        /// <summary>A value indicating whether the agent details are to be fetched.</summary>
        string FetchAgentDetail { get; set; }
        /// <summary>The FQDN to be used for fetching agent details.</summary>
        string Fqdn { get; set; }
        /// <summary>The OS type to be used for fetching agent details.</summary>
        string OSType { get; set; }
        /// <summary>A value indicating whether the zone to zone mappings are to be returned.</summary>
        string ZoneToZoneMapping { get; set; }

    }
}