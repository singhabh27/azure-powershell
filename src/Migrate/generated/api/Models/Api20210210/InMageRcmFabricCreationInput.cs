namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm fabric provider specific settings.</summary>
    public partial class InMageRcmFabricCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInput __fabricSpecificCreationInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.FabricSpecificCreationInput();

        /// <summary>Gets the class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)__fabricSpecificCreationInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)__fabricSpecificCreationInput).InstanceType = value ?? null; }

        /// <summary>Internal Acessors for SourceAgentIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal.SourceAgentIdentity { get => (this._sourceAgentIdentity = this._sourceAgentIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set { {_sourceAgentIdentity = value;} } }

        /// <summary>Backing field for <see cref="PhysicalSiteId" /> property.</summary>
        private string _physicalSiteId;

        /// <summary>The ARM Id of the physical site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PhysicalSiteId { get => this._physicalSiteId; set => this._physicalSiteId = value; }

        /// <summary>Backing field for <see cref="SourceAgentIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput _sourceAgentIdentity;

        /// <summary>The identity provider input for source agent authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput SourceAgentIdentity { get => (this._sourceAgentIdentity = this._sourceAgentIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInput()); set => this._sourceAgentIdentity = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SourceAgentIdentityAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).AadAuthority = value ; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SourceAgentIdentityApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).ApplicationId = value ; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SourceAgentIdentityAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).Audience = value ; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SourceAgentIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).ObjectId = value ; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SourceAgentIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInputInternal)SourceAgentIdentity).TenantId = value ; }

        /// <summary>Backing field for <see cref="VmwareSiteId" /> property.</summary>
        private string _vmwareSiteId;

        /// <summary>The ARM Id of the VMware site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VmwareSiteId { get => this._vmwareSiteId; set => this._vmwareSiteId = value; }

        /// <summary>Creates an new <see cref="InMageRcmFabricCreationInput" /> instance.</summary>
        public InMageRcmFabricCreationInput()
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
            await eventListener.AssertNotNull(nameof(__fabricSpecificCreationInput), __fabricSpecificCreationInput);
            await eventListener.AssertObjectIsValid(nameof(__fabricSpecificCreationInput), __fabricSpecificCreationInput);
        }
    }
    /// InMageRcm fabric provider specific settings.
    public partial interface IInMageRcmFabricCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInput
    {
        /// <summary>The ARM Id of the physical site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ARM Id of the physical site.",
        SerializedName = @"physicalSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalSiteId { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAgentIdentityAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAgentIdentityApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAgentIdentityAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAgentIdentityObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAgentIdentityTenantId { get; set; }
        /// <summary>The ARM Id of the VMware site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ARM Id of the VMware site.",
        SerializedName = @"vmwareSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string VmwareSiteId { get; set; }

    }
    /// InMageRcm fabric provider specific settings.
    internal partial interface IInMageRcmFabricCreationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal
    {
        /// <summary>The ARM Id of the physical site.</summary>
        string PhysicalSiteId { get; set; }
        /// <summary>The identity provider input for source agent authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput SourceAgentIdentity { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string SourceAgentIdentityAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string SourceAgentIdentityApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string SourceAgentIdentityAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string SourceAgentIdentityObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string SourceAgentIdentityTenantId { get; set; }
        /// <summary>The ARM Id of the VMware site.</summary>
        string VmwareSiteId { get; set; }

    }
}