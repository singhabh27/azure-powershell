namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Event details for InMageRcm provider.</summary>
    public partial class InMageRcmEventDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetails __eventProviderSpecificDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.EventProviderSpecificDetails();

        /// <summary>Backing field for <see cref="ApplianceName" /> property.</summary>
        private string _applianceName;

        /// <summary>The appliance name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ApplianceName { get => this._applianceName; }

        /// <summary>Backing field for <see cref="ComponentDisplayName" /> property.</summary>
        private string _componentDisplayName;

        /// <summary>The component display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ComponentDisplayName { get => this._componentDisplayName; }

        /// <summary>Backing field for <see cref="FabricName" /> property.</summary>
        private string _fabricName;

        /// <summary>The fabric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string FabricName { get => this._fabricName; }

        /// <summary>Gets the class type. Overridden in derived classes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal)__eventProviderSpecificDetails).InstanceType; }

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        /// <summary>The job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; }

        /// <summary>Backing field for <see cref="LatestAgentVersion" /> property.</summary>
        private string _latestAgentVersion;

        /// <summary>The latest agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LatestAgentVersion { get => this._latestAgentVersion; }

        /// <summary>Internal Acessors for InstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal.InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal)__eventProviderSpecificDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal)__eventProviderSpecificDetails).InstanceType = value; }

        /// <summary>Internal Acessors for ApplianceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.ApplianceName { get => this._applianceName; set { {_applianceName = value;} } }

        /// <summary>Internal Acessors for ComponentDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.ComponentDisplayName { get => this._componentDisplayName; set { {_componentDisplayName = value;} } }

        /// <summary>Internal Acessors for FabricName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.FabricName { get => this._fabricName; set { {_fabricName = value;} } }

        /// <summary>Internal Acessors for JobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.JobId { get => this._jobId; set { {_jobId = value;} } }

        /// <summary>Internal Acessors for LatestAgentVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.LatestAgentVersion { get => this._latestAgentVersion; set { {_latestAgentVersion = value;} } }

        /// <summary>Internal Acessors for ProtectedItemName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.ProtectedItemName { get => this._protectedItemName; set { {_protectedItemName = value;} } }

        /// <summary>Internal Acessors for ServerType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.ServerType { get => this._serverType; set { {_serverType = value;} } }

        /// <summary>Internal Acessors for VMName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEventDetailsInternal.VMName { get => this._vMName; set { {_vMName = value;} } }

        /// <summary>Backing field for <see cref="ProtectedItemName" /> property.</summary>
        private string _protectedItemName;

        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProtectedItemName { get => this._protectedItemName; }

        /// <summary>Backing field for <see cref="ServerType" /> property.</summary>
        private string _serverType;

        /// <summary>The server type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ServerType { get => this._serverType; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; }

        /// <summary>Creates an new <see cref="InMageRcmEventDetails" /> instance.</summary>
        public InMageRcmEventDetails()
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
            await eventListener.AssertNotNull(nameof(__eventProviderSpecificDetails), __eventProviderSpecificDetails);
            await eventListener.AssertObjectIsValid(nameof(__eventProviderSpecificDetails), __eventProviderSpecificDetails);
        }
    }
    /// Event details for InMageRcm provider.
    public partial interface IInMageRcmEventDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetails
    {
        /// <summary>The appliance name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The appliance name.",
        SerializedName = @"applianceName",
        PossibleTypes = new [] { typeof(string) })]
        string ApplianceName { get;  }
        /// <summary>The component display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The component display name.",
        SerializedName = @"componentDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ComponentDisplayName { get;  }
        /// <summary>The fabric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fabric name.",
        SerializedName = @"fabricName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricName { get;  }
        /// <summary>The job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The job Id.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get;  }
        /// <summary>The latest agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The latest agent version.",
        SerializedName = @"latestAgentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LatestAgentVersion { get;  }
        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The protected item name.",
        SerializedName = @"protectedItemName",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectedItemName { get;  }
        /// <summary>The server type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The server type.",
        SerializedName = @"serverType",
        PossibleTypes = new [] { typeof(string) })]
        string ServerType { get;  }
        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The protected item name.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get;  }

    }
    /// Event details for InMageRcm provider.
    internal partial interface IInMageRcmEventDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEventProviderSpecificDetailsInternal
    {
        /// <summary>The appliance name.</summary>
        string ApplianceName { get; set; }
        /// <summary>The component display name.</summary>
        string ComponentDisplayName { get; set; }
        /// <summary>The fabric name.</summary>
        string FabricName { get; set; }
        /// <summary>The job Id.</summary>
        string JobId { get; set; }
        /// <summary>The latest agent version.</summary>
        string LatestAgentVersion { get; set; }
        /// <summary>The protected item name.</summary>
        string ProtectedItemName { get; set; }
        /// <summary>The server type.</summary>
        string ServerType { get; set; }
        /// <summary>The protected item name.</summary>
        string VMName { get; set; }

    }
}