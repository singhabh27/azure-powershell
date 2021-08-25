// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the availability for scheduling data box orders orders.</summary>
    public partial class DataBoxScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataBoxScheduleAvailabilityRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IDataBoxScheduleAvailabilityRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest __scheduleAvailabilityRequest = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ScheduleAvailabilityRequest();

        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).Country = value ?? null; }

        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).SkuName = value ; }

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StorageLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).StorageLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal)__scheduleAvailabilityRequest).StorageLocation = value ; }

        /// <summary>Creates an new <see cref="DataBoxScheduleAvailabilityRequest" /> instance.</summary>
        public DataBoxScheduleAvailabilityRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scheduleAvailabilityRequest), __scheduleAvailabilityRequest);
            await eventListener.AssertObjectIsValid(nameof(__scheduleAvailabilityRequest), __scheduleAvailabilityRequest);
        }
    }
    /// Request body to get the availability for scheduling data box orders orders.
    public partial interface IDataBoxScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequest
    {

    }
    /// Request body to get the availability for scheduling data box orders orders.
    internal partial interface IDataBoxScheduleAvailabilityRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IScheduleAvailabilityRequestInternal
    {

    }
}