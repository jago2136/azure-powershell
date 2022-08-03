// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>The properties indicating whether a given service name is available.</summary>
    public partial class ServicesNameAvailabilityInfo :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesNameAvailabilityInfo,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesNameAvailabilityInfoInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The detailed reason message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Internal Acessors for NameAvailable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesNameAvailabilityInfoInternal.NameAvailable { get => this._nameAvailable; set { {_nameAvailable = value;} } }

        /// <summary>Internal Acessors for Reason</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason? Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesNameAvailabilityInfoInternal.Reason { get => this._reason; set { {_reason = value;} } }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>The value which indicates whether the provided name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason? _reason;

        /// <summary>The reason for unavailability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason? Reason { get => this._reason; }

        /// <summary>Creates an new <see cref="ServicesNameAvailabilityInfo" /> instance.</summary>
        public ServicesNameAvailabilityInfo()
        {

        }
    }
    /// The properties indicating whether a given service name is available.
    public partial interface IServicesNameAvailabilityInfo :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>The detailed reason message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detailed reason message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The value which indicates whether the provided name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The value which indicates whether the provided name is available.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get;  }
        /// <summary>The reason for unavailability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The reason for unavailability.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason? Reason { get;  }

    }
    /// The properties indicating whether a given service name is available.
    internal partial interface IServicesNameAvailabilityInfoInternal

    {
        /// <summary>The detailed reason message.</summary>
        string Message { get; set; }
        /// <summary>The value which indicates whether the provided name is available.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason for unavailability.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceNameUnavailabilityReason? Reason { get; set; }

    }
}