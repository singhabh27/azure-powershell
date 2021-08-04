namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(IPConfigDetailsTypeConverter))]
    public partial class IPConfigDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IPConfigDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IPConfigDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IPConfigDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IPConfigDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsPrimary = (bool?) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).SubnetName = (string) content.GetValueForProperty("SubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).SubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).StaticIPAddress = (string) content.GetValueForProperty("StaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).StaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IPAddressType = (string) content.GetValueForProperty("IPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IPAddressType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsSeletedForFailover = (bool?) content.GetValueForProperty("IsSeletedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsSeletedForFailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryStaticIPAddress = (string) content.GetValueForProperty("RecoveryStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryIPAddressType = (string) content.GetValueForProperty("RecoveryIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryIPAddressType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryPublicIPAddressId = (string) content.GetValueForProperty("RecoveryPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryLbBackendAddressPoolId = (string[]) content.GetValueForProperty("RecoveryLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoSubnetName = (string) content.GetValueForProperty("TfoSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoStaticIPAddress = (string) content.GetValueForProperty("TfoStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoPublicIPAddressId = (string) content.GetValueForProperty("TfoPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoLbBackendAddressPoolId = (string[]) content.GetValueForProperty("TfoLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPConfigDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IPConfigDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsPrimary = (bool?) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).SubnetName = (string) content.GetValueForProperty("SubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).SubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).StaticIPAddress = (string) content.GetValueForProperty("StaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).StaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IPAddressType = (string) content.GetValueForProperty("IPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IPAddressType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsSeletedForFailover = (bool?) content.GetValueForProperty("IsSeletedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).IsSeletedForFailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoverySubnetName = (string) content.GetValueForProperty("RecoverySubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoverySubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryStaticIPAddress = (string) content.GetValueForProperty("RecoveryStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryIPAddressType = (string) content.GetValueForProperty("RecoveryIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryIPAddressType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryPublicIPAddressId = (string) content.GetValueForProperty("RecoveryPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryLbBackendAddressPoolId = (string[]) content.GetValueForProperty("RecoveryLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).RecoveryLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoSubnetName = (string) content.GetValueForProperty("TfoSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoStaticIPAddress = (string) content.GetValueForProperty("TfoStaticIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoStaticIPAddress, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoPublicIPAddressId = (string) content.GetValueForProperty("TfoPublicIPAddressId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoPublicIPAddressId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoLbBackendAddressPoolId = (string[]) content.GetValueForProperty("TfoLbBackendAddressPoolId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IIPConfigDetailsInternal)this).TfoLbBackendAddressPoolId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(IPConfigDetailsTypeConverter))]
    public partial interface IIPConfigDetails

    {

    }
}