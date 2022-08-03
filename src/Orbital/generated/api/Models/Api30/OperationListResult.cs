// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>
    /// A list of REST API operations supported by an Azure Resource Provider. It contains an URL link to get the next set of
    /// results.
    /// </summary>
    public partial class OperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperationListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperationListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperationListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation[] Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperationListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation[] _value;

        /// <summary>List of operations supported by the resource provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationListResult" /> instance.</summary>
        public OperationListResult()
        {

        }
    }
    /// A list of REST API operations supported by an Azure Resource Provider. It contains an URL link to get the next set of
    /// results.
    public partial interface IOperationListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of operation list results (if there are any).",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of operations supported by the resource provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of operations supported by the resource provider",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation[] Value { get;  }

    }
    /// A list of REST API operations supported by an Azure Resource Provider. It contains an URL link to get the next set of
    /// results.
    internal partial interface IOperationListResultInternal

    {
        /// <summary>URL to get the next set of operation list results (if there are any).</summary>
        string NextLink { get; set; }
        /// <summary>List of operations supported by the resource provider</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IOperation[] Value { get; set; }

    }
}