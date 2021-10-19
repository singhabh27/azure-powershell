// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>publicationFacet</summary>
    public partial class MicrosoftGraphPublicationFacet :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPublicationFacet,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPublicationFacetInternal
    {

        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private string _level;

        /// <summary>
        /// The state of publication for this document. Either published or checkout. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Level { get => this._level; set => this._level = value; }

        /// <summary>Backing field for <see cref="VersionId" /> property.</summary>
        private string _versionId;

        /// <summary>
        /// The unique identifier for the version that is visible to the current caller. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string VersionId { get => this._versionId; set => this._versionId = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphPublicationFacet" /> instance.</summary>
        public MicrosoftGraphPublicationFacet()
        {

        }
    }
    /// publicationFacet
    public partial interface IMicrosoftGraphPublicationFacet :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// The state of publication for this document. Either published or checkout. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state of publication for this document. Either published or checkout. Read-only.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(string) })]
        string Level { get; set; }
        /// <summary>
        /// The unique identifier for the version that is visible to the current caller. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier for the version that is visible to the current caller. Read-only.",
        SerializedName = @"versionId",
        PossibleTypes = new [] { typeof(string) })]
        string VersionId { get; set; }

    }
    /// publicationFacet
    internal partial interface IMicrosoftGraphPublicationFacetInternal

    {
        /// <summary>
        /// The state of publication for this document. Either published or checkout. Read-only.
        /// </summary>
        string Level { get; set; }
        /// <summary>
        /// The unique identifier for the version that is visible to the current caller. Read-only.
        /// </summary>
        string VersionId { get; set; }

    }
}