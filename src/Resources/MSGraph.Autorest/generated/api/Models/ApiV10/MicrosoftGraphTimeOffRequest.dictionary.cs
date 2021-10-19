// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    public partial class MicrosoftGraphTimeOffRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {

        global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>.AdditionalProperties { get => __microsoftGraphScheduleChangeRequest.AdditionalProperties; }

        int Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>.Count { get => __microsoftGraphScheduleChangeRequest.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>.Keys { get => __microsoftGraphScheduleChangeRequest.Keys; }

        global::System.Collections.Generic.IEnumerable<global::System.Object> Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>.Values { get => __microsoftGraphScheduleChangeRequest.Values; }

        public global::System.Object this[global::System.String index] { get => __microsoftGraphScheduleChangeRequest[index]; set => __microsoftGraphScheduleChangeRequest[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, global::System.Object value) => __microsoftGraphScheduleChangeRequest.Add( key, value);

        public void Clear() => __microsoftGraphScheduleChangeRequest.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __microsoftGraphScheduleChangeRequest.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() { "EndDateTime","StartDateTime","TimeOffReasonId","Id","CreatedDateTime","LastModifiedDateTime","LastModifiedBy","AssignedTo","ManagerActionDateTime","ManagerActionMessage","ManagerUserId","SenderDateTime","SenderMessage","SenderUserId","State" } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__microsoftGraphScheduleChangeRequest.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<global::System.Object>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() { "EndDateTime","StartDateTime","TimeOffReasonId","Id","CreatedDateTime","LastModifiedDateTime","LastModifiedBy","AssignedTo","ManagerActionDateTime","ManagerActionMessage","ManagerUserId","SenderDateTime","SenderMessage","SenderUserId","State" } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__microsoftGraphScheduleChangeRequest.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<global::System.Object>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __microsoftGraphScheduleChangeRequest.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out global::System.Object value) => __microsoftGraphScheduleChangeRequest.TryGetValue( key, out value);
    }
}