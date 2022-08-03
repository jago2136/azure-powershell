// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for the url redirect action.</summary>
    public partial class UrlRedirectActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal
    {

        /// <summary>Backing field for <see cref="CustomFragment" /> property.</summary>
        private string _customFragment;

        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomFragment { get => this._customFragment; set => this._customFragment = value; }

        /// <summary>Backing field for <see cref="CustomHostname" /> property.</summary>
        private string _customHostname;

        /// <summary>Host to redirect. Leave empty to use the incoming host as the destination host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomHostname { get => this._customHostname; set => this._customHostname = value; }

        /// <summary>Backing field for <see cref="CustomPath" /> property.</summary>
        private string _customPath;

        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination
        /// path.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomPath { get => this._customPath; set => this._customPath = value; }

        /// <summary>Backing field for <see cref="CustomQueryString" /> property.</summary>
        private string _customQueryString;

        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string;
        /// leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. ? and & will be added
        /// automatically so do not include them.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string CustomQueryString { get => this._customQueryString; set => this._customQueryString = value; }

        /// <summary>Backing field for <see cref="DestinationProtocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol? _destinationProtocol;

        /// <summary>Protocol to use for the redirect. The default value is MatchRequest</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol? DestinationProtocol { get => this._destinationProtocol; set => this._destinationProtocol = value; }

        /// <summary>Internal Acessors for TypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IUrlRedirectActionParametersInternal.TypeName { get => this._typeName; set { {_typeName = value;} } }

        /// <summary>Backing field for <see cref="RedirectType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType _redirectType;

        /// <summary>The redirect type the rule will use when redirecting traffic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType RedirectType { get => this._redirectType; set => this._redirectType = value; }

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName= @"DeliveryRuleUrlRedirectActionParameters";

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; }

        /// <summary>Creates an new <see cref="UrlRedirectActionParameters" /> instance.</summary>
        public UrlRedirectActionParameters()
        {

        }
    }
    /// Defines the parameters for the url redirect action.
    public partial interface IUrlRedirectActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.",
        SerializedName = @"customFragment",
        PossibleTypes = new [] { typeof(string) })]
        string CustomFragment { get; set; }
        /// <summary>Host to redirect. Leave empty to use the incoming host as the destination host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host to redirect. Leave empty to use the incoming host as the destination host.",
        SerializedName = @"customHostname",
        PossibleTypes = new [] { typeof(string) })]
        string CustomHostname { get; set; }
        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination
        /// path.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination path.",
        SerializedName = @"customPath",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPath { get; set; }
        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string;
        /// leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. ? and & will be added
        /// automatically so do not include them.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string; leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. ? and & will be added automatically so do not include them.",
        SerializedName = @"customQueryString",
        PossibleTypes = new [] { typeof(string) })]
        string CustomQueryString { get; set; }
        /// <summary>Protocol to use for the redirect. The default value is MatchRequest</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Protocol to use for the redirect. The default value is MatchRequest",
        SerializedName = @"destinationProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol? DestinationProtocol { get; set; }
        /// <summary>The redirect type the rule will use when redirecting traffic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The redirect type the rule will use when redirecting traffic.",
        SerializedName = @"redirectType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType RedirectType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string TypeName { get;  }

    }
    /// Defines the parameters for the url redirect action.
    internal partial interface IUrlRedirectActionParametersInternal

    {
        /// <summary>
        /// Fragment to add to the redirect URL. Fragment is the part of the URL that comes after #. Do not include the #.
        /// </summary>
        string CustomFragment { get; set; }
        /// <summary>Host to redirect. Leave empty to use the incoming host as the destination host.</summary>
        string CustomHostname { get; set; }
        /// <summary>
        /// The full path to redirect. Path cannot be empty and must start with /. Leave empty to use the incoming path as destination
        /// path.
        /// </summary>
        string CustomPath { get; set; }
        /// <summary>
        /// The set of query strings to be placed in the redirect URL. Setting this value would replace any existing query string;
        /// leave empty to preserve the incoming query string. Query string must be in <key>=<value> format. ? and & will be added
        /// automatically so do not include them.
        /// </summary>
        string CustomQueryString { get; set; }
        /// <summary>Protocol to use for the redirect. The default value is MatchRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DestinationProtocol? DestinationProtocol { get; set; }
        /// <summary>The redirect type the rule will use when redirecting traffic.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RedirectType RedirectType { get; set; }

        string TypeName { get; set; }

    }
}