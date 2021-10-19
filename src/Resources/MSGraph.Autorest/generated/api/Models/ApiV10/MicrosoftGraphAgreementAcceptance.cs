// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>agreementAcceptance</summary>
    public partial class MicrosoftGraphAgreementAcceptance :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAgreementAcceptance,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAgreementAcceptanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="AgreementFileId" /> property.</summary>
        private string _agreementFileId;

        /// <summary>ID of the agreement file accepted by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AgreementFileId { get => this._agreementFileId; set => this._agreementFileId = value; }

        /// <summary>Backing field for <see cref="AgreementId" /> property.</summary>
        private string _agreementId;

        /// <summary>ID of the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string AgreementId { get => this._agreementId; set => this._agreementId = value; }

        /// <summary>Backing field for <see cref="DeviceDisplayName" /> property.</summary>
        private string _deviceDisplayName;

        /// <summary>The display name of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DeviceDisplayName { get => this._deviceDisplayName; set => this._deviceDisplayName = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="DeviceOSType" /> property.</summary>
        private string _deviceOSType;

        /// <summary>The operating system used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DeviceOSType { get => this._deviceOSType; set => this._deviceOSType = value; }

        /// <summary>Backing field for <see cref="DeviceOSVersion" /> property.</summary>
        private string _deviceOSVersion;

        /// <summary>The operating system version of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DeviceOSVersion { get => this._deviceOSVersion; set => this._deviceOSVersion = value; }

        /// <summary>Backing field for <see cref="ExpirationDateTime" /> property.</summary>
        private global::System.DateTime? _expirationDateTime;

        /// <summary>
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? ExpirationDateTime { get => this._expirationDateTime; set => this._expirationDateTime = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="RecordedDateTime" /> property.</summary>
        private global::System.DateTime? _recordedDateTime;

        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? RecordedDateTime { get => this._recordedDateTime; set => this._recordedDateTime = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="UserDisplayName" /> property.</summary>
        private string _userDisplayName;

        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string UserDisplayName { get => this._userDisplayName; set => this._userDisplayName = value; }

        /// <summary>Backing field for <see cref="UserEmail" /> property.</summary>
        private string _userEmail;

        /// <summary>Email of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string UserEmail { get => this._userEmail; set => this._userEmail = value; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>ID of the user who accepted the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string UserId { get => this._userId; set => this._userId = value; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphAgreementAcceptance" /> instance.</summary>
        public MicrosoftGraphAgreementAcceptance()
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
    /// agreementAcceptance
    public partial interface IMicrosoftGraphAgreementAcceptance :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>ID of the agreement file accepted by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the agreement file accepted by the user.",
        SerializedName = @"agreementFileId",
        PossibleTypes = new [] { typeof(string) })]
        string AgreementFileId { get; set; }
        /// <summary>ID of the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the agreement.",
        SerializedName = @"agreementId",
        PossibleTypes = new [] { typeof(string) })]
        string AgreementId { get; set; }
        /// <summary>The display name of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the device used for accepting the agreement.",
        SerializedName = @"deviceDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceDisplayName { get; set; }
        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier of the device used for accepting the agreement.",
        SerializedName = @"deviceId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }
        /// <summary>The operating system used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operating system used for accepting the agreement.",
        SerializedName = @"deviceOSType",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceOSType { get; set; }
        /// <summary>The operating system version of the device used for accepting the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operating system version of the device used for accepting the agreement.",
        SerializedName = @"deviceOSVersion",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceOSVersion { get; set; }
        /// <summary>
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"expirationDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpirationDateTime { get; set; }
        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z",
        SerializedName = @"recordedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecordedDateTime { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the user when the acceptance was recorded.",
        SerializedName = @"userDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDisplayName { get; set; }
        /// <summary>Email of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of the user when the acceptance was recorded.",
        SerializedName = @"userEmail",
        PossibleTypes = new [] { typeof(string) })]
        string UserEmail { get; set; }
        /// <summary>ID of the user who accepted the agreement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the user who accepted the agreement.",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get; set; }
        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UPN of the user when the acceptance was recorded.",
        SerializedName = @"userPrincipalName",
        PossibleTypes = new [] { typeof(string) })]
        string UserPrincipalName { get; set; }

    }
    /// agreementAcceptance
    internal partial interface IMicrosoftGraphAgreementAcceptanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        /// <summary>ID of the agreement file accepted by the user.</summary>
        string AgreementFileId { get; set; }
        /// <summary>ID of the agreement.</summary>
        string AgreementId { get; set; }
        /// <summary>The display name of the device used for accepting the agreement.</summary>
        string DeviceDisplayName { get; set; }
        /// <summary>The unique identifier of the device used for accepting the agreement.</summary>
        string DeviceId { get; set; }
        /// <summary>The operating system used for accepting the agreement.</summary>
        string DeviceOSType { get; set; }
        /// <summary>The operating system version of the device used for accepting the agreement.</summary>
        string DeviceOSVersion { get; set; }
        /// <summary>
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format
        /// and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        global::System.DateTime? ExpirationDateTime { get; set; }
        /// <summary>
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        global::System.DateTime? RecordedDateTime { get; set; }

        string State { get; set; }
        /// <summary>Display name of the user when the acceptance was recorded.</summary>
        string UserDisplayName { get; set; }
        /// <summary>Email of the user when the acceptance was recorded.</summary>
        string UserEmail { get; set; }
        /// <summary>ID of the user who accepted the agreement.</summary>
        string UserId { get; set; }
        /// <summary>UPN of the user when the acceptance was recorded.</summary>
        string UserPrincipalName { get; set; }

    }
}