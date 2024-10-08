// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for FirewallPolicyDeploymentsOperations
    /// </summary>
    public static partial class FirewallPolicyDeploymentsOperationsExtensions
    {
        /// <summary>
        /// Deploys the firewall policy draft and child rule collection group drafts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        public static FirewallPolicyDeploymentsDeployHeaders Deploy(this IFirewallPolicyDeploymentsOperations operations, string resourceGroupName, string firewallPolicyName)
        {
                return ((IFirewallPolicyDeploymentsOperations)operations).DeployAsync(resourceGroupName, firewallPolicyName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deploys the firewall policy draft and child rule collection group drafts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<FirewallPolicyDeploymentsDeployHeaders> DeployAsync(this IFirewallPolicyDeploymentsOperations operations, string resourceGroupName, string firewallPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DeployWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
        /// <summary>
        /// Deploys the firewall policy draft and child rule collection group drafts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        public static FirewallPolicyDeploymentsDeployHeaders BeginDeploy(this IFirewallPolicyDeploymentsOperations operations, string resourceGroupName, string firewallPolicyName)
        {
                return ((IFirewallPolicyDeploymentsOperations)operations).BeginDeployAsync(resourceGroupName, firewallPolicyName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deploys the firewall policy draft and child rule collection group drafts.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='firewallPolicyName'>
        /// The name of the Firewall Policy.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<FirewallPolicyDeploymentsDeployHeaders> BeginDeployAsync(this IFirewallPolicyDeploymentsOperations operations, string resourceGroupName, string firewallPolicyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDeployWithHttpMessagesAsync(resourceGroupName, firewallPolicyName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
    }
}
