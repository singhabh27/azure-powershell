namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Replication protection intent objects collection.</summary>
    public partial class ReplicationProtectionIntentCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntentCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntent[] _value;

        /// <summary>The Replication protection intent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntent[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ReplicationProtectionIntentCollection" /> instance.</summary>
        public ReplicationProtectionIntentCollection()
        {

        }
    }
    /// Replication protection intent objects collection.
    public partial interface IReplicationProtectionIntentCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The value of next link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value of next link.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The Replication protection intent details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Replication protection intent details.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntent) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntent[] Value { get; set; }

    }
    /// Replication protection intent objects collection.
    internal partial interface IReplicationProtectionIntentCollectionInternal

    {
        /// <summary>The value of next link.</summary>
        string NextLink { get; set; }
        /// <summary>The Replication protection intent details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProtectionIntent[] Value { get; set; }

    }
}