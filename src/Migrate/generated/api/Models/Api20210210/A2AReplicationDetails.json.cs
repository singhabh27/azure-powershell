namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A provider specific settings.</summary>
    public partial class A2AReplicationDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="A2AReplicationDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal A2AReplicationDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __replicationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProviderSpecificSettings(json);
            {_vMSyncedConfigDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("vmSyncedConfigDetails"), out var __jsonVMSyncedConfigDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.AzureToAzureVMSyncedConfigDetails.FromJson(__jsonVMSyncedConfigDetails) : VMSyncedConfigDetail;}
            {_fabricObjectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("fabricObjectId"), out var __jsonFabricObjectId) ? (string)__jsonFabricObjectId : (string)FabricObjectId;}
            {_initialPrimaryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialPrimaryZone"), out var __jsonInitialPrimaryZone) ? (string)__jsonInitialPrimaryZone : (string)InitialPrimaryZone;}
            {_initialPrimaryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialPrimaryFabricLocation"), out var __jsonInitialPrimaryFabricLocation) ? (string)__jsonInitialPrimaryFabricLocation : (string)InitialPrimaryFabricLocation;}
            {_initialRecoveryZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialRecoveryZone"), out var __jsonInitialRecoveryZone) ? (string)__jsonInitialRecoveryZone : (string)InitialRecoveryZone;}
            {_initialRecoveryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("initialRecoveryFabricLocation"), out var __jsonInitialRecoveryFabricLocation) ? (string)__jsonInitialRecoveryFabricLocation : (string)InitialRecoveryFabricLocation;}
            {_multiVMGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupId"), out var __jsonMultiVMGroupId) ? (string)__jsonMultiVMGroupId : (string)MultiVMGroupId;}
            {_multiVMGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupName"), out var __jsonMultiVMGroupName) ? (string)__jsonMultiVMGroupName : (string)MultiVMGroupName;}
            {_multiVMGroupCreateOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupCreateOption"), out var __jsonMultiVMGroupCreateOption) ? (string)__jsonMultiVMGroupCreateOption : (string)MultiVMGroupCreateOption;}
            {_managementId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("managementId"), out var __jsonManagementId) ? (string)__jsonManagementId : (string)ManagementId;}
            {_protectedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("protectedDisks"), out var __jsonProtectedDisks) ? If( __jsonProtectedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectedDiskDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectedDiskDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectedDiskDetails.FromJson(__u) )) ))() : null : ProtectedDisk;}
            {_unprotectedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("unprotectedDisks"), out var __jsonUnprotectedDisks) ? If( __jsonUnprotectedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AUnprotectedDiskDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AUnprotectedDiskDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AUnprotectedDiskDetails.FromJson(__p) )) ))() : null : UnprotectedDisk;}
            {_protectedManagedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("protectedManagedDisks"), out var __jsonProtectedManagedDisks) ? If( __jsonProtectedManagedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectedManagedDiskDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectedManagedDiskDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectedManagedDiskDetails.FromJson(__k) )) ))() : null : ProtectedManagedDisk;}
            {_recoveryBootDiagStorageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryBootDiagStorageAccountId"), out var __jsonRecoveryBootDiagStorageAccountId) ? (string)__jsonRecoveryBootDiagStorageAccountId : (string)RecoveryBootDiagStorageAccountId;}
            {_primaryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("primaryFabricLocation"), out var __jsonPrimaryFabricLocation) ? (string)__jsonPrimaryFabricLocation : (string)PrimaryFabricLocation;}
            {_recoveryFabricLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryFabricLocation"), out var __jsonRecoveryFabricLocation) ? (string)__jsonRecoveryFabricLocation : (string)RecoveryFabricLocation;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_recoveryAzureVMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureVMSize"), out var __jsonRecoveryAzureVMSize) ? (string)__jsonRecoveryAzureVMSize : (string)RecoveryAzureVMSize;}
            {_recoveryAzureVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureVMName"), out var __jsonRecoveryAzureVMName) ? (string)__jsonRecoveryAzureVMName : (string)RecoveryAzureVMName;}
            {_recoveryAzureResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureResourceGroupId"), out var __jsonRecoveryAzureResourceGroupId) ? (string)__jsonRecoveryAzureResourceGroupId : (string)RecoveryAzureResourceGroupId;}
            {_recoveryCloudService = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryCloudService"), out var __jsonRecoveryCloudService) ? (string)__jsonRecoveryCloudService : (string)RecoveryCloudService;}
            {_recoveryAvailabilitySet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAvailabilitySet"), out var __jsonRecoveryAvailabilitySet) ? (string)__jsonRecoveryAvailabilitySet : (string)RecoveryAvailabilitySet;}
            {_selectedRecoveryAzureNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("selectedRecoveryAzureNetworkId"), out var __jsonSelectedRecoveryAzureNetworkId) ? (string)__jsonSelectedRecoveryAzureNetworkId : (string)SelectedRecoveryAzureNetworkId;}
            {_selectedTfoAzureNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("selectedTfoAzureNetworkId"), out var __jsonSelectedTfoAzureNetworkId) ? (string)__jsonSelectedTfoAzureNetworkId : (string)SelectedTfoAzureNetworkId;}
            {_vMNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("vmNics"), out var __jsonVMNics) ? If( __jsonVMNics as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IVMNicDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.VMNicDetails.FromJson(__f) )) ))() : null : VMNic;}
            {_monitoringPercentageCompletion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("monitoringPercentageCompletion"), out var __jsonMonitoringPercentageCompletion) ? (int?)__jsonMonitoringPercentageCompletion : MonitoringPercentageCompletion;}
            {_monitoringJobType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("monitoringJobType"), out var __jsonMonitoringJobType) ? (string)__jsonMonitoringJobType : (string)MonitoringJobType;}
            {_lastHeartbeat = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("lastHeartbeat"), out var __jsonLastHeartbeat) ? global::System.DateTime.TryParse((string)__jsonLastHeartbeat, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastHeartbeatValue) ? __jsonLastHeartbeatValue : LastHeartbeat : LastHeartbeat;}
            {_agentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("agentVersion"), out var __jsonAgentVersion) ? (string)__jsonAgentVersion : (string)AgentVersion;}
            {_agentExpiryDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("agentExpiryDate"), out var __jsonAgentExpiryDate) ? global::System.DateTime.TryParse((string)__jsonAgentExpiryDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonAgentExpiryDateValue) ? __jsonAgentExpiryDateValue : AgentExpiryDate : AgentExpiryDate;}
            {_isReplicationAgentUpdateRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("isReplicationAgentUpdateRequired"), out var __jsonIsReplicationAgentUpdateRequired) ? (bool?)__jsonIsReplicationAgentUpdateRequired : IsReplicationAgentUpdateRequired;}
            {_agentCertificateExpiryDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("agentCertificateExpiryDate"), out var __jsonAgentCertificateExpiryDate) ? global::System.DateTime.TryParse((string)__jsonAgentCertificateExpiryDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonAgentCertificateExpiryDateValue) ? __jsonAgentCertificateExpiryDateValue : AgentCertificateExpiryDate : AgentCertificateExpiryDate;}
            {_isReplicationAgentCertificateUpdateRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean>("isReplicationAgentCertificateUpdateRequired"), out var __jsonIsReplicationAgentCertificateUpdateRequired) ? (bool?)__jsonIsReplicationAgentCertificateUpdateRequired : IsReplicationAgentCertificateUpdateRequired;}
            {_recoveryFabricObjectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryFabricObjectId"), out var __jsonRecoveryFabricObjectId) ? (string)__jsonRecoveryFabricObjectId : (string)RecoveryFabricObjectId;}
            {_vMProtectionState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vmProtectionState"), out var __jsonVMProtectionState) ? (string)__jsonVMProtectionState : (string)VMProtectionState;}
            {_vMProtectionStateDescription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vmProtectionStateDescription"), out var __jsonVMProtectionStateDescription) ? (string)__jsonVMProtectionStateDescription : (string)VMProtectionStateDescription;}
            {_lifecycleId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("lifecycleId"), out var __jsonLifecycleId) ? (string)__jsonLifecycleId : (string)LifecycleId;}
            {_testFailoverRecoveryFabricObjectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("testFailoverRecoveryFabricObjectId"), out var __jsonTestFailoverRecoveryFabricObjectId) ? (string)__jsonTestFailoverRecoveryFabricObjectId : (string)TestFailoverRecoveryFabricObjectId;}
            {_rpoInSecond = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("rpoInSeconds"), out var __jsonRpoInSeconds) ? (long?)__jsonRpoInSeconds : RpoInSecond;}
            {_lastRpoCalculatedTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("lastRpoCalculatedTime"), out var __jsonLastRpoCalculatedTime) ? global::System.DateTime.TryParse((string)__jsonLastRpoCalculatedTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastRpoCalculatedTimeValue) ? __jsonLastRpoCalculatedTimeValue : LastRpoCalculatedTime : LastRpoCalculatedTime;}
            {_primaryAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("primaryAvailabilityZone"), out var __jsonPrimaryAvailabilityZone) ? (string)__jsonPrimaryAvailabilityZone : (string)PrimaryAvailabilityZone;}
            {_recoveryAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAvailabilityZone"), out var __jsonRecoveryAvailabilityZone) ? (string)__jsonRecoveryAvailabilityZone : (string)RecoveryAvailabilityZone;}
            {_vMEncryptionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vmEncryptionType"), out var __jsonVMEncryptionType) ? (string)__jsonVMEncryptionType : (string)VMEncryptionType;}
            {_tfoAzureVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("tfoAzureVMName"), out var __jsonTfoAzureVMName) ? (string)__jsonTfoAzureVMName : (string)TfoAzureVMName;}
            {_recoveryAzureGeneration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureGeneration"), out var __jsonRecoveryAzureGeneration) ? (string)__jsonRecoveryAzureGeneration : (string)RecoveryAzureGeneration;}
            {_recoveryProximityPlacementGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryProximityPlacementGroupId"), out var __jsonRecoveryProximityPlacementGroupId) ? (string)__jsonRecoveryProximityPlacementGroupId : (string)RecoveryProximityPlacementGroupId;}
            {_autoProtectionOfDataDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("autoProtectionOfDataDisk"), out var __jsonAutoProtectionOfDataDisk) ? (string)__jsonAutoProtectionOfDataDisk : (string)AutoProtectionOfDataDisk;}
            {_recoveryVirtualMachineScaleSetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryVirtualMachineScaleSetId"), out var __jsonRecoveryVirtualMachineScaleSetId) ? (string)__jsonRecoveryVirtualMachineScaleSetId : (string)RecoveryVirtualMachineScaleSetId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new A2AReplicationDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="A2AReplicationDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="A2AReplicationDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __replicationProviderSpecificSettings?.ToJson(container, serializationMode);
            AddIf( null != this._vMSyncedConfigDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._vMSyncedConfigDetail.ToJson(null,serializationMode) : null, "vmSyncedConfigDetails" ,container.Add );
            AddIf( null != (((object)this._fabricObjectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._fabricObjectId.ToString()) : null, "fabricObjectId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._initialPrimaryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialPrimaryZone.ToString()) : null, "initialPrimaryZone" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._initialPrimaryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialPrimaryFabricLocation.ToString()) : null, "initialPrimaryFabricLocation" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._initialRecoveryZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialRecoveryZone.ToString()) : null, "initialRecoveryZone" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._initialRecoveryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._initialRecoveryFabricLocation.ToString()) : null, "initialRecoveryFabricLocation" ,container.Add );
            }
            AddIf( null != (((object)this._multiVMGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupId.ToString()) : null, "multiVmGroupId" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupName.ToString()) : null, "multiVmGroupName" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupCreateOption)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupCreateOption.ToString()) : null, "multiVmGroupCreateOption" ,container.Add );
            AddIf( null != (((object)this._managementId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._managementId.ToString()) : null, "managementId" ,container.Add );
            if (null != this._protectedDisk)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._protectedDisk )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("protectedDisks",__w);
            }
            if (null != this._unprotectedDisk)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __s in this._unprotectedDisk )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("unprotectedDisks",__r);
            }
            if (null != this._protectedManagedDisk)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __n in this._protectedManagedDisk )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("protectedManagedDisks",__m);
            }
            AddIf( null != (((object)this._recoveryBootDiagStorageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryBootDiagStorageAccountId.ToString()) : null, "recoveryBootDiagStorageAccountId" ,container.Add );
            AddIf( null != (((object)this._primaryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._primaryFabricLocation.ToString()) : null, "primaryFabricLocation" ,container.Add );
            AddIf( null != (((object)this._recoveryFabricLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryFabricLocation.ToString()) : null, "recoveryFabricLocation" ,container.Add );
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            AddIf( null != (((object)this._recoveryAzureVMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureVMSize.ToString()) : null, "recoveryAzureVMSize" ,container.Add );
            AddIf( null != (((object)this._recoveryAzureVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureVMName.ToString()) : null, "recoveryAzureVMName" ,container.Add );
            AddIf( null != (((object)this._recoveryAzureResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureResourceGroupId.ToString()) : null, "recoveryAzureResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._recoveryCloudService)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryCloudService.ToString()) : null, "recoveryCloudService" ,container.Add );
            AddIf( null != (((object)this._recoveryAvailabilitySet)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAvailabilitySet.ToString()) : null, "recoveryAvailabilitySet" ,container.Add );
            AddIf( null != (((object)this._selectedRecoveryAzureNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._selectedRecoveryAzureNetworkId.ToString()) : null, "selectedRecoveryAzureNetworkId" ,container.Add );
            AddIf( null != (((object)this._selectedTfoAzureNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._selectedTfoAzureNetworkId.ToString()) : null, "selectedTfoAzureNetworkId" ,container.Add );
            if (null != this._vMNic)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __i in this._vMNic )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("vmNics",__h);
            }
            AddIf( null != this._monitoringPercentageCompletion ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._monitoringPercentageCompletion) : null, "monitoringPercentageCompletion" ,container.Add );
            AddIf( null != (((object)this._monitoringJobType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._monitoringJobType.ToString()) : null, "monitoringJobType" ,container.Add );
            AddIf( null != this._lastHeartbeat ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._lastHeartbeat?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastHeartbeat" ,container.Add );
            AddIf( null != (((object)this._agentVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._agentVersion.ToString()) : null, "agentVersion" ,container.Add );
            AddIf( null != this._agentExpiryDate ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._agentExpiryDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "agentExpiryDate" ,container.Add );
            AddIf( null != this._isReplicationAgentUpdateRequired ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._isReplicationAgentUpdateRequired) : null, "isReplicationAgentUpdateRequired" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._agentCertificateExpiryDate ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._agentCertificateExpiryDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "agentCertificateExpiryDate" ,container.Add );
            }
            AddIf( null != this._isReplicationAgentCertificateUpdateRequired ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonBoolean((bool)this._isReplicationAgentCertificateUpdateRequired) : null, "isReplicationAgentCertificateUpdateRequired" ,container.Add );
            AddIf( null != (((object)this._recoveryFabricObjectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryFabricObjectId.ToString()) : null, "recoveryFabricObjectId" ,container.Add );
            AddIf( null != (((object)this._vMProtectionState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vMProtectionState.ToString()) : null, "vmProtectionState" ,container.Add );
            AddIf( null != (((object)this._vMProtectionStateDescription)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vMProtectionStateDescription.ToString()) : null, "vmProtectionStateDescription" ,container.Add );
            AddIf( null != (((object)this._lifecycleId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._lifecycleId.ToString()) : null, "lifecycleId" ,container.Add );
            AddIf( null != (((object)this._testFailoverRecoveryFabricObjectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._testFailoverRecoveryFabricObjectId.ToString()) : null, "testFailoverRecoveryFabricObjectId" ,container.Add );
            AddIf( null != this._rpoInSecond ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._rpoInSecond) : null, "rpoInSeconds" ,container.Add );
            AddIf( null != this._lastRpoCalculatedTime ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._lastRpoCalculatedTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastRpoCalculatedTime" ,container.Add );
            AddIf( null != (((object)this._primaryAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._primaryAvailabilityZone.ToString()) : null, "primaryAvailabilityZone" ,container.Add );
            AddIf( null != (((object)this._recoveryAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAvailabilityZone.ToString()) : null, "recoveryAvailabilityZone" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._vMEncryptionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vMEncryptionType.ToString()) : null, "vmEncryptionType" ,container.Add );
            }
            AddIf( null != (((object)this._tfoAzureVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._tfoAzureVMName.ToString()) : null, "tfoAzureVMName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._recoveryAzureGeneration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureGeneration.ToString()) : null, "recoveryAzureGeneration" ,container.Add );
            }
            AddIf( null != (((object)this._recoveryProximityPlacementGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryProximityPlacementGroupId.ToString()) : null, "recoveryProximityPlacementGroupId" ,container.Add );
            AddIf( null != (((object)this._autoProtectionOfDataDisk)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._autoProtectionOfDataDisk.ToString()) : null, "autoProtectionOfDataDisk" ,container.Add );
            AddIf( null != (((object)this._recoveryVirtualMachineScaleSetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryVirtualMachineScaleSetId.ToString()) : null, "recoveryVirtualMachineScaleSetId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}