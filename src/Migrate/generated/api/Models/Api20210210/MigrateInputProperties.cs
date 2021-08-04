namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Migrate input properties.</summary>
    public partial class MigrateInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProviderSpecificDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateProviderSpecificInput _providerSpecificDetail;

        /// <summary>The provider specific details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateProviderSpecificInput ProviderSpecificDetail { get => (this._providerSpecificDetail = this._providerSpecificDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.MigrateProviderSpecificInput()); set => this._providerSpecificDetail = value; }

        /// <summary>Creates an new <see cref="MigrateInputProperties" /> instance.</summary>
        public MigrateInputProperties()
        {

        }
    }
    /// Migrate input properties.
    public partial interface IMigrateInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The provider specific details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The provider specific details.",
        SerializedName = @"providerSpecificDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
    /// Migrate input properties.
    internal partial interface IMigrateInputPropertiesInternal

    {
        /// <summary>The provider specific details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IMigrateProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
}