namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Input required to add a provider.</summary>
    public partial class AddRecoveryServicesProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputInternal
    {

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputAadAuthority = value ; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputApplicationId = value ; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputAudience = value ; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputObjectId = value ; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string AuthenticationIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInputTenantId = value ; }

        /// <summary>The Bios Id of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string BiosId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).BiosId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).BiosId = value ?? null; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputAadAuthority = value ?? null; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputApplicationId = value ?? null; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputAudience = value ?? null; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputObjectId = value ?? null; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string DataPlaneAuthenticationIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInputTenantId = value ?? null; }

        /// <summary>The Id of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).MachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).MachineId = value ?? null; }

        /// <summary>The name of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string MachineName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).MachineName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).MachineName = value ; }

        /// <summary>Internal Acessors for AuthenticationIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputInternal.AuthenticationIdentityInput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInput; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).AuthenticationIdentityInput = value; }

        /// <summary>Internal Acessors for DataPlaneAuthenticationIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputInternal.DataPlaneAuthenticationIdentityInput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInput; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).DataPlaneAuthenticationIdentityInput = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.AddRecoveryServicesProviderInputProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ResourceAccessIdentityInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputInternal.ResourceAccessIdentityInput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInput; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInput = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputProperties _property;

        /// <summary>The properties of an add provider request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.AddRecoveryServicesProviderInputProperties()); set => this._property = value; }

        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputAadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputAadAuthority = value ; }

        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputApplicationId = value ; }

        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputAudience = value ; }

        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputObjectId = value ; }

        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResourceAccessIdentityInputTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputPropertiesInternal)Property).ResourceAccessIdentityInputTenantId = value ; }

        /// <summary>Creates an new <see cref="AddRecoveryServicesProviderInput" /> instance.</summary>
        public AddRecoveryServicesProviderInput()
        {

        }
    }
    /// Input required to add a provider.
    public partial interface IAddRecoveryServicesProviderInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationIdentityInputAadAuthority { get; set; }
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
        string AuthenticationIdentityInputApplicationId { get; set; }
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
        string AuthenticationIdentityInputAudience { get; set; }
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
        string AuthenticationIdentityInputObjectId { get; set; }
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
        string AuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Bios Id of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Bios Id of the machine.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application/client Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The intended Audience of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The object Id of the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant Id for the service principal with which the on-premise management/data plane components would communicate with our Azure services.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string DataPlaneAuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Id of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the machine where the provider is getting added.",
        SerializedName = @"machineId",
        PossibleTypes = new [] { typeof(string) })]
        string MachineId { get; set; }
        /// <summary>The name of the machine where the provider is getting added.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the machine where the provider is getting added.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base authority for Azure Active Directory authentication.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessIdentityInputAadAuthority { get; set; }
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
        string ResourceAccessIdentityInputApplicationId { get; set; }
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
        string ResourceAccessIdentityInputAudience { get; set; }
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
        string ResourceAccessIdentityInputObjectId { get; set; }
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
        string ResourceAccessIdentityInputTenantId { get; set; }

    }
    /// Input required to add a provider.
    internal partial interface IAddRecoveryServicesProviderInputInternal

    {
        /// <summary>The identity provider input for DRA authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput AuthenticationIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string AuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string AuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string AuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Bios Id of the machine.</summary>
        string BiosId { get; set; }
        /// <summary>The identity provider input for data plane authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput DataPlaneAuthenticationIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string DataPlaneAuthenticationIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string DataPlaneAuthenticationIdentityInputTenantId { get; set; }
        /// <summary>The Id of the machine where the provider is getting added.</summary>
        string MachineId { get; set; }
        /// <summary>The name of the machine where the provider is getting added.</summary>
        string MachineName { get; set; }
        /// <summary>The properties of an add provider request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAddRecoveryServicesProviderInputProperties Property { get; set; }
        /// <summary>The identity provider input for resource access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput ResourceAccessIdentityInput { get; set; }
        /// <summary>The base authority for Azure Active Directory authentication.</summary>
        string ResourceAccessIdentityInputAadAuthority { get; set; }
        /// <summary>
        /// The application/client Id for the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputApplicationId { get; set; }
        /// <summary>
        /// The intended Audience of the service principal with which the on-premise management/data plane components would communicate
        /// with our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputAudience { get; set; }
        /// <summary>
        /// The object Id of the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputObjectId { get; set; }
        /// <summary>
        /// The tenant Id for the service principal with which the on-premise management/data plane components would communicate with
        /// our Azure services.
        /// </summary>
        string ResourceAccessIdentityInputTenantId { get; set; }

    }
}