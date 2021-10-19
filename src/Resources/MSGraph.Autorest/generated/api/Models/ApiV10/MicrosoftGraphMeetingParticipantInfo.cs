// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>meetingParticipantInfo</summary>
    public partial class MicrosoftGraphMeetingParticipantInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipantInfo,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphMeetingParticipantInfoInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet _identity;

        /// <summary>identitySet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphIdentitySet()); set => this._identity = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Role { get => this._role; set => this._role = value; }

        /// <summary>Backing field for <see cref="Upn" /> property.</summary>
        private string _upn;

        /// <summary>User principal name of the participant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Upn { get => this._upn; set => this._upn = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphMeetingParticipantInfo" /> instance.</summary>
        public MicrosoftGraphMeetingParticipantInfo()
        {

        }
    }
    /// meetingParticipantInfo
    public partial interface IMicrosoftGraphMeetingParticipantInfo :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>identitySet</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"identitySet",
        SerializedName = @"identity",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet Identity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        string Role { get; set; }
        /// <summary>User principal name of the participant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User principal name of the participant.",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string Upn { get; set; }

    }
    /// meetingParticipantInfo
    internal partial interface IMicrosoftGraphMeetingParticipantInfoInternal

    {
        /// <summary>identitySet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphIdentitySet Identity { get; set; }

        string Role { get; set; }
        /// <summary>User principal name of the participant.</summary>
        string Upn { get; set; }

    }
}