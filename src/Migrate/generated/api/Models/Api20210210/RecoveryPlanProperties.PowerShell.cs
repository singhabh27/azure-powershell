namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Recovery plan properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryPlanPropertiesTypeConverter))]
    public partial class RecoveryPlanProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryPlanProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryPlanProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryPlanProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryPlanProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenario = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentScenarioDetails) content.GetValueForProperty("CurrentScenario",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenario, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CurrentScenarioDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricId = (string) content.GetValueForProperty("PrimaryFabricId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricFriendlyName = (string) content.GetValueForProperty("PrimaryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricId = (string) content.GetValueForProperty("RecoveryFabricId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricFriendlyName = (string) content.GetValueForProperty("RecoveryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FailoverDeploymentModel = (string) content.GetValueForProperty("FailoverDeploymentModel",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FailoverDeploymentModel, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ReplicationProvider = (string[]) content.GetValueForProperty("ReplicationProvider",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ReplicationProvider, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).AllowedOperation = (string[]) content.GetValueForProperty("AllowedOperation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).AllowedOperation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatus = (string) content.GetValueForProperty("CurrentScenarioStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatusDescription = (string) content.GetValueForProperty("CurrentScenarioStatusDescription",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatusDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).Group = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroup[]) content.GetValueForProperty("Group",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).Group, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanGroupTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificDetails[]) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ProviderSpecificDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProviderSpecificDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioName = (string) content.GetValueForProperty("CurrentScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioJobId = (string) content.GetValueForProperty("CurrentScenarioJobId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioJobId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentScenarioStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryPlanProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenario = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ICurrentScenarioDetails) content.GetValueForProperty("CurrentScenario",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenario, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.CurrentScenarioDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricId = (string) content.GetValueForProperty("PrimaryFabricId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricFriendlyName = (string) content.GetValueForProperty("PrimaryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).PrimaryFabricFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricId = (string) content.GetValueForProperty("RecoveryFabricId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricFriendlyName = (string) content.GetValueForProperty("RecoveryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).RecoveryFabricFriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FailoverDeploymentModel = (string) content.GetValueForProperty("FailoverDeploymentModel",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).FailoverDeploymentModel, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ReplicationProvider = (string[]) content.GetValueForProperty("ReplicationProvider",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ReplicationProvider, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).AllowedOperation = (string[]) content.GetValueForProperty("AllowedOperation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).AllowedOperation, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).LastTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatus = (string) content.GetValueForProperty("CurrentScenarioStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatusDescription = (string) content.GetValueForProperty("CurrentScenarioStatusDescription",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStatusDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).Group = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroup[]) content.GetValueForProperty("Group",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).Group, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanGroupTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ProviderSpecificDetail = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificDetails[]) content.GetValueForProperty("ProviderSpecificDetail",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).ProviderSpecificDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanProviderSpecificDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryPlanProviderSpecificDetailsTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioName = (string) content.GetValueForProperty("CurrentScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioJobId = (string) content.GetValueForProperty("CurrentScenarioJobId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioJobId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentScenarioStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryPlanPropertiesInternal)this).CurrentScenarioStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery plan properties.
    [System.ComponentModel.TypeConverter(typeof(RecoveryPlanPropertiesTypeConverter))]
    public partial interface IRecoveryPlanProperties

    {

    }
}