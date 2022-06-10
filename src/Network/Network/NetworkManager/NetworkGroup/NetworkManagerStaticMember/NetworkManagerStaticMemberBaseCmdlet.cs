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
    public abstract class NetworkManagerStaticMemberBaseCmdlet : NetworkBaseCmdlet
    {
        public IStaticMembersOperations NetworkManagerStaticMemberClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.StaticMembers;
            }
        }

        public bool IsNetworkManagerStaticMemberPresent(string resourceGroupName, string networkManagerName, string networkManagerGroupName, string name)
        {
            try
            {
                GetNetworkManagerStaticMember(resourceGroupName, networkManagerName, networkManagerGroupName, name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == HttpStatusCode.NotFound || exception.Response.StatusCode ==  HttpStatusCode.BadRequest)
                {
                    // Resource is not present
                    return false;
                }
                throw;
            }

            return true;
        }


        public PSNetworkManagerStaticMember GetNetworkManagerStaticMember(string resourceGroupName, string networkManagerName, string networkManagerGroup, string name)
        {
            var networkManagerStaticMember = this.NetworkManagerStaticMemberClient.Get(resourceGroupName, networkManagerName, networkManagerGroup, name);
            var psNetworkManagerStaticMember = NetworkResourceManagerProfile.Mapper.Map<PSNetworkManagerStaticMember>(networkManagerStaticMember);
            return psNetworkManagerStaticMember;
        }

        // Temporary - to be removed
        public void NullifyNetworkManagerStaticMemberIfAbsent(StaticMember staticMember)
        {
            if (staticMember == null)
            {
                return;
            }
        }

        public PSNetworkManagerStaticMember ToPsNetworkManagerStaticMember(StaticMember networkManagerStaticMember)
        {
            var psNetworkManagerStaticMember = NetworkResourceManagerProfile.Mapper.Map<PSNetworkManagerStaticMember>(networkManagerStaticMember);
            return psNetworkManagerStaticMember;
        }
    }
}