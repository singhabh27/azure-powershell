namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Supported operating system details.</summary>
    public partial class SupportedOSDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ISupportedOSDetailsInternal
    {

        /// <summary>Backing field for <see cref="OSName" /> property.</summary>
        private string _oSName;

        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSName { get => this._oSName; set => this._oSName = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="OSVersion" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSVersionWrapper[] _oSVersion;

        /// <summary>The list of version for operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSVersionWrapper[] OSVersion { get => this._oSVersion; set => this._oSVersion = value; }

        /// <summary>Creates an new <see cref="SupportedOSDetails" /> instance.</summary>
        public SupportedOSDetails()
        {

        }
    }
    /// Supported operating system details.
    public partial interface ISupportedOSDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name.",
        SerializedName = @"osName",
        PossibleTypes = new [] { typeof(string) })]
        string OSName { get; set; }
        /// <summary>The type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>The list of version for operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of version for operating system.",
        SerializedName = @"osVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSVersionWrapper) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSVersionWrapper[] OSVersion { get; set; }

    }
    /// Supported operating system details.
    internal partial interface ISupportedOSDetailsInternal

    {
        /// <summary>The name.</summary>
        string OSName { get; set; }
        /// <summary>The type.</summary>
        string OSType { get; set; }
        /// <summary>The list of version for operating system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IOSVersionWrapper[] OSVersion { get; set; }

    }
}