// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>Error details.</summary>
    public partial class ErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetails,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetailsInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetails _error;

        /// <summary>Error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetails Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.InternalErrorDetails()); set => this._error = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetailsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetails Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetailsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.InternalErrorDetails()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetailsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IErrorDetailsInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Target = value; }

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetailsInternal)Error).Target; }

        /// <summary>Creates an new <see cref="ErrorDetails" /> instance.</summary>
        public ErrorDetails()
        {

        }
    }
    /// Error details.
    public partial interface IErrorDetails :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// Error details.
    internal partial interface IErrorDetailsInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>Error details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IInternalErrorDetails Error { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}