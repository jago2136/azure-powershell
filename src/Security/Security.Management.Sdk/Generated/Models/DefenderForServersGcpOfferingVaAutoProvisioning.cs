// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Vulnerability Assessment autoprovisioning configuration
    /// </summary>
    public partial class DefenderForServersGcpOfferingVaAutoProvisioning
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DefenderForServersGcpOfferingVaAutoProvisioning class.
        /// </summary>
        public DefenderForServersGcpOfferingVaAutoProvisioning()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DefenderForServersGcpOfferingVaAutoProvisioning class.
        /// </summary>
        /// <param name="enabled">Is Vulnerability Assessment auto provisioning
        /// enabled</param>
        /// <param name="configuration">configuration for Vulnerability
        /// Assessment autoprovisioning</param>
        public DefenderForServersGcpOfferingVaAutoProvisioning(bool? enabled = default(bool?), DefenderForServersGcpOfferingVaAutoProvisioningConfiguration configuration = default(DefenderForServersGcpOfferingVaAutoProvisioningConfiguration))
        {
            Enabled = enabled;
            Configuration = configuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is Vulnerability Assessment auto provisioning enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets configuration for Vulnerability Assessment
        /// autoprovisioning
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public DefenderForServersGcpOfferingVaAutoProvisioningConfiguration Configuration { get; set; }

    }
}
