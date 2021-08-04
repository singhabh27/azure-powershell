namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(IPConfigInputDetailsTypeConverter))]
    public partial class IPConfigInputDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IPConfigInputDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IPConfigInputDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IPConfigInputDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IPConfigInputDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IPConfigName = (string) content.GetValueForProperty("IPConfigName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IPConfigName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsPrimary = (bool?) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsSeletedForFailover = (bool?) content.GetValueForProperty("IsSeletedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsSeletedForFailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryStaticIPAddress = (string) content.GetValueForProperty("RecoveryStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryPublicIPAddressId = (string) content.GetValueForProperty("RecoveryPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryLbBackendAddressPoolId = (string[]) content.GetValueForProperty("RecoveryLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoSubnetName = (string) content.GetValueForProperty("TfoSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoStaticIPAddress = (string) content.GetValueForProperty("TfoStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoPublicIPAddressId = (string) content.GetValueForProperty("TfoPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoLbBackendAddressPoolId = (string[]) content.GetValueForProperty("TfoLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigInputDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IPConfigInputDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IPConfigName = (string) content.GetValueForProperty("IPConfigName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IPConfigName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsPrimary = (bool?) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsSeletedForFailover = (bool?) content.GetValueForProperty("IsSeletedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).IsSeletedForFailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryStaticIPAddress = (string) content.GetValueForProperty("RecoveryStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryPublicIPAddressId = (string) content.GetValueForProperty("RecoveryPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryLbBackendAddressPoolId = (string[]) content.GetValueForProperty("RecoveryLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).RecoveryLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoSubnetName = (string) content.GetValueForProperty("TfoSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoStaticIPAddress = (string) content.GetValueForProperty("TfoStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoPublicIPAddressId = (string) content.GetValueForProperty("TfoPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoLbBackendAddressPoolId = (string[]) content.GetValueForProperty("TfoLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigInputDetailsInternal)this).TfoLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(IPConfigInputDetailsTypeConverter))]
    public partial interface IIPConfigInputDetails

    {

    }
}