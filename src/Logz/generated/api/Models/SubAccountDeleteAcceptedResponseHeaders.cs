// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Logz.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Extensions;

    public partial class SubAccountDeleteAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.ISubAccountDeleteAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.ISubAccountDeleteAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Origin(Microsoft.Azure.PowerShell.Cmdlets.Logz.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Logz.Models.ISubAccountDeleteAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="SubAccountDeleteAcceptedResponseHeaders" /> instance.</summary>
        public SubAccountDeleteAcceptedResponseHeaders()
        {

        }
    }
    public partial interface ISubAccountDeleteAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Logz.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface ISubAccountDeleteAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}