// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>recurrenceRange</summary>
    public partial class MicrosoftGraphRecurrenceRange
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphRecurrenceRange.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphRecurrenceRange.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphRecurrenceRange FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json ? new MicrosoftGraphRecurrenceRange(json, new global::System.Collections.Generic.HashSet<string>(){ @"endDate",@"numberOfOccurrences",@"recurrenceTimeZone",@"startDate",@"type" }) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphRecurrenceRange" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal MicrosoftGraphRecurrenceRange(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            {_endDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("endDate"), out var __jsonEndDate) ? global::System.DateTime.TryParse((string)__jsonEndDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndDateValue) ? __jsonEndDateValue : EndDate : EndDate;}
            {_numberOfOccurrence = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber>("numberOfOccurrences"), out var __jsonNumberOfOccurrences) ? (int?)__jsonNumberOfOccurrences : NumberOfOccurrence;}
            {_recurrenceTimeZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("recurrenceTimeZone"), out var __jsonRecurrenceTimeZone) ? (string)__jsonRecurrenceTimeZone : (string)RecurrenceTimeZone;}
            {_startDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("startDate"), out var __jsonStartDate) ? global::System.DateTime.TryParse((string)__jsonStartDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartDateValue) ? __jsonStartDateValue : StartDate : StartDate;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphRecurrenceRange" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphRecurrenceRange" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.ToJson( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, container);
            AddIf( null != this._endDate ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._endDate?.ToString(@"yyyy-MM-dd",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endDate" ,container.Add );
            AddIf( null != this._numberOfOccurrence ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber((int)this._numberOfOccurrence) : null, "numberOfOccurrences" ,container.Add );
            AddIf( null != (((object)this._recurrenceTimeZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._recurrenceTimeZone.ToString()) : null, "recurrenceTimeZone" ,container.Add );
            AddIf( null != this._startDate ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._startDate?.ToString(@"yyyy-MM-dd",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startDate" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}