// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Capture logs and metrics of Azure resources based on ARM tags.</summary>
    public partial class MonitoringTagRules :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRules,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public string Id { get => this._id; }

        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available
        /// resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IFilteringTag[] LogRuleFilteringTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleFilteringTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleFilteringTag = value ?? null /* arrayOf */; }

        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public bool? LogRuleSendAadLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendAadLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendAadLog = value ?? default(bool); }

        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public bool? LogRuleSendActivityLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendActivityLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendActivityLog = value ?? default(bool); }

        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public bool? LogRuleSendSubscriptionLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendSubscriptionLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRuleSendSubscriptionLog = value ?? default(bool); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for LogRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.ILogRules Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.LogRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).LogRule = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesProperties Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.MonitoringTagRulesProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesProperties _property;

        /// <summary>Properties of the monitoring tag rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.MonitoringTagRulesProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the monitoring tag rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.FormatTable(Index = 1)]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/").Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemData _systemData;

        /// <summary>The system metadata relating to this resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType)""); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="MonitoringTagRules" /> instance.</summary>
        public MonitoringTagRules()
        {

        }
    }
    /// Capture logs and metrics of Azure resources based on ARM tags.
    public partial interface IMonitoringTagRules :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>The id of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The id of the rule set.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available
        /// resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.",
        SerializedName = @"filteringTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IFilteringTag) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IFilteringTag[] LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if AAD logs should be sent for the Monitor resource.",
        SerializedName = @"sendAadLogs",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.",
        SerializedName = @"sendActivityLogs",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag specifying if subscription logs should be sent for the Monitor resource.",
        SerializedName = @"sendSubscriptionLogs",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LogRuleSendSubscriptionLog { get; set; }
        /// <summary>Name of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the rule set.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Provisioning state of the monitoring tag rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the monitoring tag rules.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the rule set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the rule set.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Capture logs and metrics of Azure resources based on ARM tags.
    internal partial interface IMonitoringTagRulesInternal

    {
        /// <summary>The id of the rule set.</summary>
        string Id { get; set; }
        /// <summary>Rules for sending logs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.ILogRules LogRule { get; set; }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available
        /// resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IFilteringTag[] LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        bool? LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        bool? LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        bool? LogRuleSendSubscriptionLog { get; set; }
        /// <summary>Name of the rule set.</summary>
        string Name { get; set; }
        /// <summary>Properties of the monitoring tag rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20200701.IMonitoringTagRulesProperties Property { get; set; }
        /// <summary>Provisioning state of the monitoring tag rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The system metadata relating to this resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the rule set.</summary>
        string Type { get; set; }

    }
}