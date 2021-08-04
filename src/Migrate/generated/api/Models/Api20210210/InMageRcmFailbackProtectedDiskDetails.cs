namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcmFailback protected disk details.</summary>
    public partial class InMageRcmFailbackProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="CapacityInByte" /> property.</summary>
        private long? _capacityInByte;

        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? CapacityInByte { get => this._capacityInByte; }

        /// <summary>Backing field for <see cref="DataPendingAtSourceAgentInMb" /> property.</summary>
        private double? _dataPendingAtSourceAgentInMb;

        /// <summary>The data pending at source agent in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? DataPendingAtSourceAgentInMb { get => this._dataPendingAtSourceAgentInMb; }

        /// <summary>Backing field for <see cref="DataPendingInLogDataStoreInMb" /> property.</summary>
        private double? _dataPendingInLogDataStoreInMb;

        /// <summary>The data pending in log data store in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? DataPendingInLogDataStoreInMb { get => this._dataPendingInLogDataStoreInMb; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk Id (reported by source agent).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; }

        /// <summary>Backing field for <see cref="DiskName" /> property.</summary>
        private string _diskName;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskName { get => this._diskName; }

        /// <summary>Backing field for <see cref="DiskUuid" /> property.</summary>
        private string _diskUuid;

        /// <summary>The disk Uuid (reported by vCenter).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskUuid { get => this._diskUuid; }

        /// <summary>Backing field for <see cref="IrDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails _irDetail;

        /// <summary>The initial replication details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails IrDetail { get => (this._irDetail = this._irDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetails()); set => this._irDetail = value; }

        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte; }

        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc; }

        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastRefreshTime; }

        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProcessedByte; }

        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressHealth; }

        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? IrDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressPercentage; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string IrDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).StartTime; }

        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? IrDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).TransferredByte; }

        /// <summary>Backing field for <see cref="IsInitialReplicationComplete" /> property.</summary>
        private string _isInitialReplicationComplete;

        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsInitialReplicationComplete { get => this._isInitialReplicationComplete; }

        /// <summary>Backing field for <see cref="IsOSDisk" /> property.</summary>
        private string _isOSDisk;

        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsOSDisk { get => this._isOSDisk; }

        /// <summary>Backing field for <see cref="LastSyncTime" /> property.</summary>
        private global::System.DateTime? _lastSyncTime;

        /// <summary>The last sync time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastSyncTime { get => this._lastSyncTime; }

        /// <summary>Internal Acessors for CapacityInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.CapacityInByte { get => this._capacityInByte; set { {_capacityInByte = value;} } }

        /// <summary>Internal Acessors for DataPendingAtSourceAgentInMb</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.DataPendingAtSourceAgentInMb { get => this._dataPendingAtSourceAgentInMb; set { {_dataPendingAtSourceAgentInMb = value;} } }

        /// <summary>Internal Acessors for DataPendingInLogDataStoreInMb</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.DataPendingInLogDataStoreInMb { get => this._dataPendingInLogDataStoreInMb; set { {_dataPendingInLogDataStoreInMb = value;} } }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>Internal Acessors for DiskName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.DiskName { get => this._diskName; set { {_diskName = value;} } }

        /// <summary>Internal Acessors for DiskUuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.DiskUuid { get => this._diskUuid; set { {_diskUuid = value;} } }

        /// <summary>Internal Acessors for IrDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetail { get => (this._irDetail = this._irDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetails()); set { {_irDetail = value;} } }

        /// <summary>Internal Acessors for IrDetailLast15MinutesTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).Last15MinutesTransferredByte = value; }

        /// <summary>Internal Acessors for IrDetailLastDataTransferTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastDataTransferTimeUtc = value; }

        /// <summary>Internal Acessors for IrDetailLastRefreshTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastRefreshTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).LastRefreshTime = value; }

        /// <summary>Internal Acessors for IrDetailProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProcessedByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProcessedByte = value; }

        /// <summary>Internal Acessors for IrDetailProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressHealth = value; }

        /// <summary>Internal Acessors for IrDetailProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).ProgressPercentage = value; }

        /// <summary>Internal Acessors for IrDetailStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).StartTime = value; }

        /// <summary>Internal Acessors for IrDetailTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IrDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).TransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)IrDetail).TransferredByte = value; }

        /// <summary>Internal Acessors for IsInitialReplicationComplete</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IsInitialReplicationComplete { get => this._isInitialReplicationComplete; set { {_isInitialReplicationComplete = value;} } }

        /// <summary>Internal Acessors for IsOSDisk</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.IsOSDisk { get => this._isOSDisk; set { {_isOSDisk = value;} } }

        /// <summary>Internal Acessors for LastSyncTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.LastSyncTime { get => this._lastSyncTime; set { {_lastSyncTime = value;} } }

        /// <summary>Internal Acessors for ResyncDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetail { get => (this._resyncDetail = this._resyncDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetails()); set { {_resyncDetail = value;} } }

        /// <summary>Internal Acessors for ResyncDetailLast15MinutesTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte = value; }

        /// <summary>Internal Acessors for ResyncDetailLastDataTransferTimeUtc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc = value; }

        /// <summary>Internal Acessors for ResyncDetailLastRefreshTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastRefreshTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastRefreshTime = value; }

        /// <summary>Internal Acessors for ResyncDetailProcessedByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProcessedByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProcessedByte = value; }

        /// <summary>Internal Acessors for ResyncDetailProgressHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressHealth = value; }

        /// <summary>Internal Acessors for ResyncDetailProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressPercentage = value; }

        /// <summary>Internal Acessors for ResyncDetailStartTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).StartTime = value; }

        /// <summary>Internal Acessors for ResyncDetailTransferredByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackProtectedDiskDetailsInternal.ResyncDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).TransferredByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).TransferredByte = value; }

        /// <summary>Backing field for <see cref="ResyncDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails _resyncDetail;

        /// <summary>The resync details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails ResyncDetail { get => (this._resyncDetail = this._resyncDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmFailbackSyncDetails()); set => this._resyncDetail = value; }

        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailLast15MinutesTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).Last15MinutesTransferredByte; }

        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailLastDataTransferTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastDataTransferTimeUtc; }

        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailLastRefreshTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).LastRefreshTime; }

        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailProcessedByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProcessedByte; }

        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressHealth; }

        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? ResyncDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).ProgressPercentage; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ResyncDetailStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).StartTime; }

        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? ResyncDetailTransferredByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetailsInternal)ResyncDetail).TransferredByte; }

        /// <summary>Creates an new <see cref="InMageRcmFailbackProtectedDiskDetails" /> instance.</summary>
        public InMageRcmFailbackProtectedDiskDetails()
        {

        }
    }
    /// InMageRcmFailback protected disk details.
    public partial interface IInMageRcmFailbackProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk capacity in bytes.",
        SerializedName = @"capacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityInByte { get;  }
        /// <summary>The data pending at source agent in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data pending at source agent in MB.",
        SerializedName = @"dataPendingAtSourceAgentInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? DataPendingAtSourceAgentInMb { get;  }
        /// <summary>The data pending in log data store in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The data pending in log data store in MB.",
        SerializedName = @"dataPendingInLogDataStoreInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? DataPendingInLogDataStoreInMb { get;  }
        /// <summary>The disk Id (reported by source agent).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk Id (reported by source agent).",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get;  }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk name.",
        SerializedName = @"diskName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskName { get;  }
        /// <summary>The disk Uuid (reported by vCenter).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk Uuid (reported by vCenter).",
        SerializedName = @"diskUuid",
        PossibleTypes = new [] { typeof(string) })]
        string DiskUuid { get;  }
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The bytes transferred in last 15 minutes from source VM to target.",
        SerializedName = @"last15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailLast15MinutesTransferredByte { get;  }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last data transfer from source VM to target.",
        SerializedName = @"lastDataTransferTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailLastDataTransferTimeUtc { get;  }
        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last refresh time.",
        SerializedName = @"lastRefreshTime",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailLastRefreshTime { get;  }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.",
        SerializedName = @"processedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailProcessedByte { get;  }
        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The progress health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get;  }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress in percentage. Progress percentage is calculated based on processed bytes.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? IrDetailProgressPercentage { get;  }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string IrDetailStartTime { get;  }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The transferred bytes from source VM to azure for the disk.",
        SerializedName = @"transferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? IrDetailTransferredByte { get;  }
        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether initial replication is complete or not.",
        SerializedName = @"isInitialReplicationComplete",
        PossibleTypes = new [] { typeof(string) })]
        string IsInitialReplicationComplete { get;  }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the disk is the OS disk.",
        SerializedName = @"isOSDisk",
        PossibleTypes = new [] { typeof(string) })]
        string IsOSDisk { get;  }
        /// <summary>The last sync time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last sync time.",
        SerializedName = @"lastSyncTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastSyncTime { get;  }
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The bytes transferred in last 15 minutes from source VM to target.",
        SerializedName = @"last15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailLast15MinutesTransferredByte { get;  }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The time of the last data transfer from source VM to target.",
        SerializedName = @"lastDataTransferTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailLastDataTransferTimeUtc { get;  }
        /// <summary>The last refresh time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last refresh time.",
        SerializedName = @"lastRefreshTime",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailLastRefreshTime { get;  }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.",
        SerializedName = @"processedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailProcessedByte { get;  }
        /// <summary>The progress health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The progress health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get;  }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Progress in percentage. Progress percentage is calculated based on processed bytes.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncDetailProgressPercentage { get;  }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncDetailStartTime { get;  }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The transferred bytes from source VM to azure for the disk.",
        SerializedName = @"transferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDetailTransferredByte { get;  }

    }
    /// InMageRcmFailback protected disk details.
    internal partial interface IInMageRcmFailbackProtectedDiskDetailsInternal

    {
        /// <summary>The disk capacity in bytes.</summary>
        long? CapacityInByte { get; set; }
        /// <summary>The data pending at source agent in MB.</summary>
        double? DataPendingAtSourceAgentInMb { get; set; }
        /// <summary>The data pending in log data store in MB.</summary>
        double? DataPendingInLogDataStoreInMb { get; set; }
        /// <summary>The disk Id (reported by source agent).</summary>
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        string DiskName { get; set; }
        /// <summary>The disk Uuid (reported by vCenter).</summary>
        string DiskUuid { get; set; }
        /// <summary>The initial replication details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails IrDetail { get; set; }
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        long? IrDetailLast15MinutesTransferredByte { get; set; }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        string IrDetailLastDataTransferTimeUtc { get; set; }
        /// <summary>The last refresh time.</summary>
        string IrDetailLastRefreshTime { get; set; }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        long? IrDetailProcessedByte { get; set; }
        /// <summary>The progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? IrDetailProgressHealth { get; set; }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        int? IrDetailProgressPercentage { get; set; }
        /// <summary>The start time.</summary>
        string IrDetailStartTime { get; set; }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        long? IrDetailTransferredByte { get; set; }
        /// <summary>A value indicating whether initial replication is complete or not.</summary>
        string IsInitialReplicationComplete { get; set; }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        string IsOSDisk { get; set; }
        /// <summary>The last sync time.</summary>
        global::System.DateTime? LastSyncTime { get; set; }
        /// <summary>The resync details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmFailbackSyncDetails ResyncDetail { get; set; }
        /// <summary>The bytes transferred in last 15 minutes from source VM to target.</summary>
        long? ResyncDetailLast15MinutesTransferredByte { get; set; }
        /// <summary>The time of the last data transfer from source VM to target.</summary>
        string ResyncDetailLastDataTransferTimeUtc { get; set; }
        /// <summary>The last refresh time.</summary>
        string ResyncDetailLastRefreshTime { get; set; }
        /// <summary>
        /// The total processed bytes. This includes bytes that are transferred from source VM to target and matched bytes.
        /// </summary>
        long? ResyncDetailProcessedByte { get; set; }
        /// <summary>The progress health.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskReplicationProgressHealth? ResyncDetailProgressHealth { get; set; }
        /// <summary>
        /// Progress in percentage. Progress percentage is calculated based on processed bytes.
        /// </summary>
        int? ResyncDetailProgressPercentage { get; set; }
        /// <summary>The start time.</summary>
        string ResyncDetailStartTime { get; set; }
        /// <summary>The transferred bytes from source VM to azure for the disk.</summary>
        long? ResyncDetailTransferredByte { get; set; }

    }
}