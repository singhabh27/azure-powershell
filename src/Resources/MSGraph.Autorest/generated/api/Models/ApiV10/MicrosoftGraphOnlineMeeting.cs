// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>onlineMeeting</summary>
    public partial class MicrosoftGraphOnlineMeeting :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnlineMeeting,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnlineMeetingInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="AllowAttendeeToEnableCamera" /> property.</summary>
        private bool? _allowAttendeeToEnableCamera;

        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? AllowAttendeeToEnableCamera { get => this._allowAttendeeToEnableCamera; set => this._allowAttendeeToEnableCamera = value; }

        /// <summary>Backing field for <see cref="AllowAttendeeToEnableMic" /> property.</summary>
        private bool? _allowAttendeeToEnableMic;

        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? AllowAttendeeToEnableMic { get => this._allowAttendeeToEnableMic; set => this._allowAttendeeToEnableMic = value; }

        /// <summary>Backing field for <see cref="AllowMeetingChat" /> property.</summary>
        private string _allowMeetingChat;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AllowMeetingChat { get => this._allowMeetingChat; set => this._allowMeetingChat = value; }

        /// <summary>Backing field for <see cref="AllowTeamworkReaction" /> property.</summary>
        private bool? _allowTeamworkReaction;

        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? AllowTeamworkReaction { get => this._allowTeamworkReaction; set => this._allowTeamworkReaction = value; }

        /// <summary>Backing field for <see cref="AllowedPresenter" /> property.</summary>
        private string _allowedPresenter;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AllowedPresenter { get => this._allowedPresenter; set => this._allowedPresenter = value; }

        /// <summary>Backing field for <see cref="AudioConferencing" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAudioConferencing _audioConferencing;

        /// <summary>audioConferencing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAudioConferencing AudioConferencing { get => (this._audioConferencing = this._audioConferencing ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphAudioConferencing()); set => this._audioConferencing = value; }

        /// <summary>Backing field for <see cref="ChatInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatInfo _chatInfo;

        /// <summary>chatInfo</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatInfo ChatInfo { get => (this._chatInfo = this._chatInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphChatInfo()); set => this._chatInfo = value; }

        /// <summary>Backing field for <see cref="CreationDateTime" /> property.</summary>
        private global::System.DateTime? _creationDateTime;

        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? CreationDateTime { get => this._creationDateTime; set => this._creationDateTime = value; }

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        /// <summary>The meeting end time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Backing field for <see cref="ExternalId" /> property.</summary>
        private string _externalId;

        /// <summary>The external ID. A custom ID. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ExternalId { get => this._externalId; set => this._externalId = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Backing field for <see cref="IsEntryExitAnnounced" /> property.</summary>
        private bool? _isEntryExitAnnounced;

        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? IsEntryExitAnnounced { get => this._isEntryExitAnnounced; set => this._isEntryExitAnnounced = value; }

        /// <summary>Backing field for <see cref="JoinInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody _joinInformation;

        /// <summary>itemBody</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody JoinInformation { get => (this._joinInformation = this._joinInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphItemBody()); set => this._joinInformation = value; }

        /// <summary>Backing field for <see cref="JoinWebUrl" /> property.</summary>
        private string _joinWebUrl;

        /// <summary>The join URL of the online meeting. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string JoinWebUrl { get => this._joinWebUrl; set => this._joinWebUrl = value; }

        /// <summary>Backing field for <see cref="LobbyBypassSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLobbyBypassSettings _lobbyBypassSetting;

        /// <summary>lobbyBypassSettings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLobbyBypassSettings LobbyBypassSetting { get => (this._lobbyBypassSetting = this._lobbyBypassSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphLobbyBypassSettings()); set => this._lobbyBypassSetting = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="Participant" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipants _participant;

        /// <summary>meetingParticipants</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipants Participant { get => (this._participant = this._participant ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphMeetingParticipants()); set => this._participant = value; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>The meeting start time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>The subject of the online meeting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; set => this._subject = value; }

        /// <summary>Backing field for <see cref="VideoTeleconferenceId" /> property.</summary>
        private string _videoTeleconferenceId;

        /// <summary>The video teleconferencing ID. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string VideoTeleconferenceId { get => this._videoTeleconferenceId; set => this._videoTeleconferenceId = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphOnlineMeeting" /> instance.</summary>
        public MicrosoftGraphOnlineMeeting()
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
    /// onlineMeeting
    public partial interface IMicrosoftGraphOnlineMeeting :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether attendees can turn on their camera.",
        SerializedName = @"allowAttendeeToEnableCamera",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether attendees can turn on their microphone.",
        SerializedName = @"allowAttendeeToEnableMic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowAttendeeToEnableMic { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowMeetingChat",
        PossibleTypes = new [] { typeof(string) })]
        string AllowMeetingChat { get; set; }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if Teams reactions are enabled for the meeting.",
        SerializedName = @"allowTeamworkReactions",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowTeamworkReaction { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowedPresenters",
        PossibleTypes = new [] { typeof(string) })]
        string AllowedPresenter { get; set; }
        /// <summary>audioConferencing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"audioConferencing",
        SerializedName = @"audioConferencing",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAudioConferencing) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAudioConferencing AudioConferencing { get; set; }
        /// <summary>chatInfo</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"chatInfo",
        SerializedName = @"chatInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The meeting creation time in UTC. Read-only.",
        SerializedName = @"creationDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The meeting end time in UTC.",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The external ID. A custom ID. Optional.",
        SerializedName = @"externalId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalId { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether to announce when callers join or leave.",
        SerializedName = @"isEntryExitAnnounced",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEntryExitAnnounced { get; set; }
        /// <summary>itemBody</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"itemBody",
        SerializedName = @"joinInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody JoinInformation { get; set; }
        /// <summary>The join URL of the online meeting. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The join URL of the online meeting. Read-only.",
        SerializedName = @"joinWebUrl",
        PossibleTypes = new [] { typeof(string) })]
        string JoinWebUrl { get; set; }
        /// <summary>lobbyBypassSettings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"lobbyBypassSettings",
        SerializedName = @"lobbyBypassSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLobbyBypassSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLobbyBypassSettings LobbyBypassSetting { get; set; }
        /// <summary>meetingParticipants</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"meetingParticipants",
        SerializedName = @"participants",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipants) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipants Participant { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The meeting start time in UTC.",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subject of the online meeting.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }
        /// <summary>The video teleconferencing ID. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The video teleconferencing ID. Read-only.",
        SerializedName = @"videoTeleconferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string VideoTeleconferenceId { get; set; }

    }
    /// onlineMeeting
    internal partial interface IMicrosoftGraphOnlineMeetingInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        bool? AllowAttendeeToEnableMic { get; set; }

        string AllowMeetingChat { get; set; }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        bool? AllowTeamworkReaction { get; set; }

        string AllowedPresenter { get; set; }
        /// <summary>audioConferencing</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAudioConferencing AudioConferencing { get; set; }
        /// <summary>chatInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        global::System.DateTime? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        string ExternalId { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        bool? IsEntryExitAnnounced { get; set; }
        /// <summary>itemBody</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody JoinInformation { get; set; }
        /// <summary>The join URL of the online meeting. Read-only.</summary>
        string JoinWebUrl { get; set; }
        /// <summary>lobbyBypassSettings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLobbyBypassSettings LobbyBypassSetting { get; set; }
        /// <summary>meetingParticipants</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipants Participant { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
        string Subject { get; set; }
        /// <summary>The video teleconferencing ID. Read-only.</summary>
        string VideoTeleconferenceId { get; set; }

    }
}