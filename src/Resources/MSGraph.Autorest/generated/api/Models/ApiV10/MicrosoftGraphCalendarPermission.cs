// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>calendarPermission</summary>
    public partial class MicrosoftGraphCalendarPermission :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCalendarPermission,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCalendarPermissionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="AllowedRole" /> property.</summary>
        private string[] _allowedRole;

        /// <summary>
        /// List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead,
        /// read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] AllowedRole { get => this._allowedRole; set => this._allowedRole = value; }

        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress _emailAddress;

        /// <summary>emailAddress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress EmailAddress { get => (this._emailAddress = this._emailAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEmailAddress()); set => this._emailAddress = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Backing field for <see cref="IsInsideOrganization" /> property.</summary>
        private bool? _isInsideOrganization;

        /// <summary>
        /// True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? IsInsideOrganization { get => this._isInsideOrganization; set => this._isInsideOrganization = value; }

        /// <summary>Backing field for <see cref="IsRemovable" /> property.</summary>
        private bool? _isRemovable;

        /// <summary>
        /// True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The
        /// 'My organization' user determines the permissions other people within your organization have to the given calendar. You
        /// cannot remove 'My organization' as a sharee to a calendar.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? IsRemovable { get => this._isRemovable; set => this._isRemovable = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Role { get => this._role; set => this._role = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphCalendarPermission" /> instance.</summary>
        public MicrosoftGraphCalendarPermission()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
        }
    }
    /// calendarPermission
    public partial interface IMicrosoftGraphCalendarPermission :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead,
        /// read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.",
        SerializedName = @"allowedRoles",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedRole { get; set; }
        /// <summary>emailAddress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"emailAddress",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress EmailAddress { get; set; }
        /// <summary>
        /// True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.",
        SerializedName = @"isInsideOrganization",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsInsideOrganization { get; set; }
        /// <summary>
        /// True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The
        /// 'My organization' user determines the permissions other people within your organization have to the given calendar. You
        /// cannot remove 'My organization' as a sharee to a calendar.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.",
        SerializedName = @"isRemovable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsRemovable { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        string Role { get; set; }

    }
    /// calendarPermission
    internal partial interface IMicrosoftGraphCalendarPermissionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        /// <summary>
        /// List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead,
        /// read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
        /// </summary>
        string[] AllowedRole { get; set; }
        /// <summary>emailAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress EmailAddress { get; set; }
        /// <summary>
        /// True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
        /// </summary>
        bool? IsInsideOrganization { get; set; }
        /// <summary>
        /// True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The
        /// 'My organization' user determines the permissions other people within your organization have to the given calendar. You
        /// cannot remove 'My organization' as a sharee to a calendar.
        /// </summary>
        bool? IsRemovable { get; set; }

        string Role { get; set; }

    }
}