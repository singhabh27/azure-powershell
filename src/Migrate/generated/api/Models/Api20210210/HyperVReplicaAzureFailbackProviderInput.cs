namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>HyperVReplicaAzureFailback specific planned failover input.</summary>
    public partial class HyperVReplicaAzureFailbackProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureFailbackProviderInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVReplicaAzureFailbackProviderInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput __plannedFailoverProviderSpecificFailoverInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PlannedFailoverProviderSpecificFailoverInput();

        /// <summary>Backing field for <see cref="DataSyncOption" /> property.</summary>
        private string _dataSyncOption;

        /// <summary>Data sync option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DataSyncOption { get => this._dataSyncOption; set => this._dataSyncOption = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal)__plannedFailoverProviderSpecificFailoverInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal)__plannedFailoverProviderSpecificFailoverInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="ProviderIdForAlternateRecovery" /> property.</summary>
        private string _providerIdForAlternateRecovery;

        /// <summary>Provider Id for alternate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProviderIdForAlternateRecovery { get => this._providerIdForAlternateRecovery; set => this._providerIdForAlternateRecovery = value; }

        /// <summary>Backing field for <see cref="RecoveryVMCreationOption" /> property.</summary>
        private string _recoveryVMCreationOption;

        /// <summary>ALR options to create alternate recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryVMCreationOption { get => this._recoveryVMCreationOption; set => this._recoveryVMCreationOption = value; }

        /// <summary>Creates an new <see cref="HyperVReplicaAzureFailbackProviderInput" /> instance.</summary>
        public HyperVReplicaAzureFailbackProviderInput()
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
            await eventListener.AssertNotNull(nameof(__plannedFailoverProviderSpecificFailoverInput), __plannedFailoverProviderSpecificFailoverInput);
            await eventListener.AssertObjectIsValid(nameof(__plannedFailoverProviderSpecificFailoverInput), __plannedFailoverProviderSpecificFailoverInput);
        }
    }
    /// HyperVReplicaAzureFailback specific planned failover input.
    public partial interface IHyperVReplicaAzureFailbackProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInput
    {
        /// <summary>Data sync option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Data sync option.",
        SerializedName = @"dataSyncOption",
        PossibleTypes = new [] { typeof(string) })]
        string DataSyncOption { get; set; }
        /// <summary>Provider Id for alternate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider Id for alternate location.",
        SerializedName = @"providerIdForAlternateRecovery",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderIdForAlternateRecovery { get; set; }
        /// <summary>ALR options to create alternate recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ALR options to create alternate recovery.",
        SerializedName = @"recoveryVmCreationOption",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVMCreationOption { get; set; }

    }
    /// HyperVReplicaAzureFailback specific planned failover input.
    internal partial interface IHyperVReplicaAzureFailbackProviderInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPlannedFailoverProviderSpecificFailoverInputInternal
    {
        /// <summary>Data sync option.</summary>
        string DataSyncOption { get; set; }
        /// <summary>Provider Id for alternate location.</summary>
        string ProviderIdForAlternateRecovery { get; set; }
        /// <summary>ALR options to create alternate recovery.</summary>
        string RecoveryVMCreationOption { get; set; }

    }
}