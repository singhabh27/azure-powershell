// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Shipping details.</summary>
    public partial class PackageShippingDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IPackageShippingDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json ? new PackageShippingDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject into a new instance of <see cref="PackageShippingDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PackageShippingDetails(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_carrierName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("carrierName"), out var __jsonCarrierName) ? (string)__jsonCarrierName : (string)CarrierName;}
            {_trackingId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("trackingId"), out var __jsonTrackingId) ? (string)__jsonTrackingId : (string)TrackingId;}
            {_trackingUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("trackingUrl"), out var __jsonTrackingUrl) ? (string)__jsonTrackingUrl : (string)TrackingUrl;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PackageShippingDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PackageShippingDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._carrierName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._carrierName.ToString()) : null, "carrierName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._trackingId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._trackingId.ToString()) : null, "trackingId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._trackingUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._trackingUrl.ToString()) : null, "trackingUrl" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}