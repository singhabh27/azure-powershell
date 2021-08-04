namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcm fabric provider specific settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFabricCreationInputTypeConverter))]
    public partial class InMageRcmFabricCreationInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmFabricCreationInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmFabricCreationInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmFabricCreationInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmFabricCreationInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput) content.GetValueForProperty("SourceAgentIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentity, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).VmwareSiteId = (string) content.GetValueForProperty("VmwareSiteId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).VmwareSiteId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).PhysicalSiteId = (string) content.GetValueForProperty("PhysicalSiteId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).PhysicalSiteId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityTenantId = (string) content.GetValueForProperty("SourceAgentIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityApplicationId = (string) content.GetValueForProperty("SourceAgentIdentityApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityObjectId = (string) content.GetValueForProperty("SourceAgentIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAudience = (string) content.GetValueForProperty("SourceAgentIdentityAudience",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAudience, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAadAuthority = (string) content.GetValueForProperty("SourceAgentIdentityAadAuthority",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAadAuthority, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFabricCreationInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmFabricCreationInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIdentityProviderInput) content.GetValueForProperty("SourceAgentIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentity, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IdentityProviderInputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).VmwareSiteId = (string) content.GetValueForProperty("VmwareSiteId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).VmwareSiteId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).PhysicalSiteId = (string) content.GetValueForProperty("PhysicalSiteId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).PhysicalSiteId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IFabricSpecificCreationInputInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityTenantId = (string) content.GetValueForProperty("SourceAgentIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityApplicationId = (string) content.GetValueForProperty("SourceAgentIdentityApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityApplicationId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityObjectId = (string) content.GetValueForProperty("SourceAgentIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAudience = (string) content.GetValueForProperty("SourceAgentIdentityAudience",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAudience, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAadAuthority = (string) content.GetValueForProperty("SourceAgentIdentityAadAuthority",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFabricCreationInputInternal)this).SourceAgentIdentityAadAuthority, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcm fabric provider specific settings.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmFabricCreationInputTypeConverter))]
    public partial interface IInMageRcmFabricCreationInput

    {

    }
}