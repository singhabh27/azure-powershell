// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>passwordCredential</summary>
    public partial class MicrosoftGraphPasswordCredential :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredential,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredentialInternal
    {

        /// <summary>Backing field for <see cref="CustomKeyIdentifier" /> property.</summary>
        private byte[] _customKeyIdentifier;

        /// <summary>Do not use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public byte[] CustomKeyIdentifier { get => this._customKeyIdentifier; set => this._customKeyIdentifier = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Friendly name for the password. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EndDateTime" /> property.</summary>
        private global::System.DateTime? _endDateTime;

        /// <summary>
        /// The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? EndDateTime { get => this._endDateTime; set => this._endDateTime = value; }

        /// <summary>Backing field for <see cref="Hint" /> property.</summary>
        private string _hint;

        /// <summary>Contains the first three characters of the password. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Hint { get => this._hint; }

        /// <summary>Backing field for <see cref="KeyId" /> property.</summary>
        private string _keyId;

        /// <summary>The unique identifier for the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string KeyId { get => this._keyId; set => this._keyId = value; }

        /// <summary>Internal Acessors for Hint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredentialInternal.Hint { get => this._hint; set { {_hint = value;} } }

        /// <summary>Internal Acessors for SecretText</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPasswordCredentialInternal.SecretText { get => this._secretText; set { {_secretText = value;} } }

        /// <summary>Backing field for <see cref="SecretText" /> property.</summary>
        private string _secretText;

        /// <summary>
        /// Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password
        /// value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the
        /// future.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string SecretText { get => this._secretText; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>
        /// The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDateTime { get => this._startDateTime; set => this._startDateTime = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphPasswordCredential" /> instance.</summary>
        public MicrosoftGraphPasswordCredential()
        {

        }
    }
    /// passwordCredential
    public partial interface IMicrosoftGraphPasswordCredential :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>Do not use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do not use.",
        SerializedName = @"customKeyIdentifier",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] CustomKeyIdentifier { get; set; }
        /// <summary>Friendly name for the password. Optional.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name for the password. Optional.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.",
        SerializedName = @"endDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Contains the first three characters of the password. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Contains the first three characters of the password. Read-only.",
        SerializedName = @"hint",
        PossibleTypes = new [] { typeof(string) })]
        string Hint { get;  }
        /// <summary>The unique identifier for the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier for the password.",
        SerializedName = @"keyId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyId { get; set; }
        /// <summary>
        /// Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password
        /// value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the
        /// future.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.",
        SerializedName = @"secretText",
        PossibleTypes = new [] { typeof(string) })]
        string SecretText { get;  }
        /// <summary>
        /// The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get; set; }

    }
    /// passwordCredential
    internal partial interface IMicrosoftGraphPasswordCredentialInternal

    {
        /// <summary>Do not use.</summary>
        byte[] CustomKeyIdentifier { get; set; }
        /// <summary>Friendly name for the password. Optional.</summary>
        string DisplayName { get; set; }
        /// <summary>
        /// The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example,
        /// midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        global::System.DateTime? EndDateTime { get; set; }
        /// <summary>Contains the first three characters of the password. Read-only.</summary>
        string Hint { get; set; }
        /// <summary>The unique identifier for the password.</summary>
        string KeyId { get; set; }
        /// <summary>
        /// Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password
        /// value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the
        /// future.
        /// </summary>
        string SecretText { get; set; }
        /// <summary>
        /// The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO
        /// 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        /// </summary>
        global::System.DateTime? StartDateTime { get; set; }

    }
}