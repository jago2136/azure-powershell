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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The external security solution properties for ATA solutions
    /// </summary>
    public partial class AtaSolutionProperties : ExternalSecuritySolutionProperties
    {
        /// <summary>
        /// Initializes a new instance of the AtaSolutionProperties class.
        /// </summary>
        public AtaSolutionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AtaSolutionProperties class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public AtaSolutionProperties(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string deviceVendor = default(string), string deviceType = default(string), ConnectedWorkspace workspace = default(ConnectedWorkspace), string lastEventReceived = default(string))
            : base(additionalProperties, deviceVendor, deviceType, workspace)
        {
            LastEventReceived = lastEventReceived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastEventReceived")]
        public string LastEventReceived { get; set; }

    }
}
