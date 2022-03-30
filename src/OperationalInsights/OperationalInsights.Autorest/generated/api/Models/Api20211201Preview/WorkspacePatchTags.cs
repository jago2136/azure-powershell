// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20211201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.Extensions;

    /// <summary>Resource tags. Optional.</summary>
    public partial class WorkspacePatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20211201Preview.IWorkspacePatchTags,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Models.Api20211201Preview.IWorkspacePatchTagsInternal
    {

        /// <summary>Creates an new <see cref="WorkspacePatchTags" /> instance.</summary>
        public WorkspacePatchTags()
        {

        }
    }
    /// Resource tags. Optional.
    public partial interface IWorkspacePatchTags :
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OperationalInsights.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags. Optional.
    internal partial interface IWorkspacePatchTagsInternal

    {

    }
}