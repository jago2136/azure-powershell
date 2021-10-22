﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Rest.Azure;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Network.Models.NetworkManager;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkManagerEffectiveConnectivityConfigurationList"), OutputType(typeof(PSNetworkManagerEffectiveConnectivityConfigurationListResult))]
    public class GetAzNetworkManageEffectiveConnectivityConfigurationListCommand : NetworkManagerBaseCmdlet
    {
        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The vnet name.")]
        [ValidateNotNullOrEmpty]
        [ResourceNameCompleter("Microsoft.Network/virtualNetworks", "ResourceGroupName")]
        [SupportsWildcards]
        public virtual string VirtualNetworkName { get; set; }

        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string ResourceGroupName { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "SkipToken.")]
        public string SkipToken { get; set; }

        public override void Execute()
        {
            base.Execute();
            var parameter = new QueryRequestOptions();

            if(!string.IsNullOrEmpty(this.SkipToken))
            {
                parameter.SkipToken = this.SkipToken;
            }
                
            var networkManagerEffectiveConnectivityConfiguration = this.NetworkClient.NetworkManagementClient.EffectiveConnectivityConfigurations.List(this.ResourceGroupName, this.VirtualNetworkName, parameter);
            var psEffectiveConnectivityConfigurationList = NetworkResourceManagerProfile.Mapper.Map<PSNetworkManagerEffectiveConnectivityConfigurationListResult>(networkManagerEffectiveConnectivityConfiguration);
            WriteObject(psEffectiveConnectivityConfigurationList);
        }
    }
}
