// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Describes the body of a purge request for an App Insights component</summary>
    public partial class ComponentPurgeBody :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBody,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyInternal
    {

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters[] _filter;

        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters[] Filter { get => this._filter; set => this._filter = value; }

        /// <summary>Backing field for <see cref="Table" /> property.</summary>
        private string _table;

        /// <summary>Table from which to purge data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        public string Table { get => this._table; set => this._table = value; }

        /// <summary>Creates an new <see cref="ComponentPurgeBody" /> instance.</summary>
        public ComponentPurgeBody()
        {

        }
    }
    /// Describes the body of a purge request for an App Insights component
    public partial interface IComponentPurgeBody :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The set of columns and filters (queries) to run over them to purge the resulting data.",
        SerializedName = @"filters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters[] Filter { get; set; }
        /// <summary>Table from which to purge data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Table from which to purge data.",
        SerializedName = @"table",
        PossibleTypes = new [] { typeof(string) })]
        string Table { get; set; }

    }
    /// Describes the body of a purge request for an App Insights component
    internal partial interface IComponentPurgeBodyInternal

    {
        /// <summary>
        /// The set of columns and filters (queries) to run over them to purge the resulting data.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api202002.IComponentPurgeBodyFilters[] Filter { get; set; }
        /// <summary>Table from which to purge data.</summary>
        string Table { get; set; }

    }
}