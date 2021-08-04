namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Vault health details definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(VaultHealthDetailsTypeConverter))]
    public partial class VaultHealthDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VaultHealthDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VaultHealthDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VaultHealthDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VaultHealthDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemsHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("ProtectedItemsHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemsHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricsHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("FabricsHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricsHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainersHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("ContainersHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainersHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).VaultError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("VaultError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).VaultError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthResourceCount = (int?) content.GetValueForProperty("ProtectedItemHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("ProtectedItemHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("ProtectedItemHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthResourceCount = (int?) content.GetValueForProperty("FabricHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("FabricHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("FabricHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthResourceCount = (int?) content.GetValueForProperty("ContainerHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("ContainerHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("ContainerHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VaultHealthDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VaultHealthPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemsHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("ProtectedItemsHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemsHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricsHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("FabricsHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricsHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainersHealth = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummary) content.GetValueForProperty("ContainersHealth",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainersHealth, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).VaultError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("VaultError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).VaultError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthResourceCount = (int?) content.GetValueForProperty("ProtectedItemHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("ProtectedItemHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("ProtectedItemHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ProtectedItemHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthResourceCount = (int?) content.GetValueForProperty("FabricHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("FabricHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("FabricHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).FabricHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthResourceCount = (int?) content.GetValueForProperty("ContainerHealthResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthResourceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthIssue = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary[]) content.GetValueForProperty("ContainerHealthIssue",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthIssue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthErrorSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorSummaryTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthCategorizedResourceCount = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceHealthSummaryCategorizedResourceCounts) content.GetValueForProperty("ContainerHealthCategorizedResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVaultHealthDetailsInternal)this).ContainerHealthCategorizedResourceCount, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ResourceHealthSummaryCategorizedResourceCountsTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }
    }
    /// Vault health details definition.
    [System.ComponentModel.TypeConverter(typeof(VaultHealthDetailsTypeConverter))]
    public partial interface IVaultHealthDetails

    {

    }
}