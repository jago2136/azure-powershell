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
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System.Net;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Commands.Network.Models.NetworkManager;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class NetworkManagerSecurityUserRuleBaseCmdlet : NetworkBaseCmdlet
    {
        public IUserRulesOperations NetworkManagerSecurityUserRuleOperationClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.UserRules;
            }
        }

        public bool IsNetworkManagerSecurityUserRulePresent(string resourceGroupName, string networkManagerName, string configName, string ruleCollectionName, string name)
        {
            try
            {
                this.NetworkManagerSecurityUserRuleOperationClient.Get(resourceGroupName, networkManagerName, configName, ruleCollectionName, name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == HttpStatusCode.NotFound || exception.Response.StatusCode == HttpStatusCode.BadRequest)
                {
                    // Resource is not present
                    return false;
                }

                throw;
            }

            return true;
        }


        public PSNetworkManagerSecurityBaseUserRule GetNetworkManagerSecurityUserRule(string resourceGroupName, string networkManagerName, string configName, string ruleCollectionName, string name)
        {
            var userRule = this.NetworkManagerSecurityUserRuleOperationClient.Get(resourceGroupName, networkManagerName, configName, ruleCollectionName, name);
            var psUserRule = this.ToPSSecurityUserRule(userRule);
            return psUserRule;
        }

        // Temporary - to be removed
        public void NullifySecurityUserRuleIfAbsent(BaseUserRule userRule)
        {
            if (userRule == null)
            {
                return;
            }
        }

        public PSNetworkManagerSecurityBaseUserRule ToPSSecurityUserRule(BaseUserRule userRule)
        {
            PSNetworkManagerSecurityBaseUserRule psUserRule;
            if (userRule.GetType().Name == "UserRule")
            {
                psUserRule = NetworkResourceManagerProfile.Mapper.Map<PSNetworkManagerSecurityUserRule>(userRule);
            }
            else if (userRule.GetType().Name == "DefaultUserRule")
            {
                psUserRule = NetworkResourceManagerProfile.Mapper.Map<PSNetworkManagerSecurityDefaultUserRule>(userRule);
            }
            else
            {
                throw new ErrorException("UnKnown User Rule Type");
            }
            return psUserRule;
        }
    }
}
