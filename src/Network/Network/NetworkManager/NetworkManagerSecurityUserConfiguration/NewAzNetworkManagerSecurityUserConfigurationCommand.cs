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

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.Network.Models.NetworkManager;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkManagerSecurityUserConfiguration", SupportsShouldProcess = true), OutputType(typeof(PSNetworkManagerSecurityConfiguration))]
    public class NewAzNetworkManagerSecurityUserConfigurationCommand : NetworkManagerSecurityUserConfigurationBaseCmdlet
    {
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string Name { get; set; }

        [Parameter(
           Mandatory = true,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The network manager name.")]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string NetworkManagerName { get; set; }

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
         HelpMessage = "DisplayName.")]
        public virtual string DisplayName { get; set; }

        [Parameter(
         Mandatory = false,
         ValueFromPipelineByPropertyName = true,
         HelpMessage = "Description.")]
        public virtual string Description { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "DeleteExistingNSGs Flag.")]
        public SwitchParameter DeleteExistingNSG { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Do not ask for confirmation if you want to overwrite a resource")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();
            var present = this.IsNetworkManagerSecurityUserConfigurationPresent(this.ResourceGroupName, this.NetworkManagerName, this.Name);
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, Name),
                Properties.Resources.CreatingResourceMessage,
                Name,
                () =>
                {
                    var networkManagerSecurityConfiguration = this.CreateNetworkManagerSecurityUserConfiguration();
                    WriteObject(networkManagerSecurityConfiguration);
                },
                () => present);
        }

        private PSNetworkManagerSecurityConfiguration CreateNetworkManagerSecurityUserConfiguration()
        {
            var securityConfig = new PSNetworkManagerSecurityConfiguration();
            securityConfig.Name = this.Name;
            if (!string.IsNullOrEmpty(this.Description))
            {
                securityConfig.Description = this.Description;
            }
            if (!string.IsNullOrEmpty(this.DisplayName))
            {
                securityConfig.DisplayName = this.DisplayName;
            }
            if (this.DeleteExistingNSG)
            {
                securityConfig.DeleteExistingNSGs = "True";
            }
            else
            {
                securityConfig.DeleteExistingNSGs = "False";
            }

            // Map to the sdk object
            var securityConfigModel = NetworkResourceManagerProfile.Mapper.Map<MNM.SecurityConfiguration>(securityConfig);

            this.NullifyNetworkManagerSecurityUserConfigurationIfAbsent(securityConfigModel);
            

            // Execute the Create Security Config call
            var securityConfigResponse = this.NetworkManagerSecurityUserConfigurationClient.CreateOrUpdate(securityConfigModel, this.ResourceGroupName, this.NetworkManagerName, this.Name);
            var psSecuirtyConfig = this.ToPsNetworkManagerSecurityUserConfiguration(securityConfigResponse);
            return psSecuirtyConfig;
        }
    }
}
