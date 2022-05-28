// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for Cookies match conditions</summary>
    public partial class CookiesMatchConditionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICookiesMatchConditionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICookiesMatchConditionParametersInternal
    {

        /// <summary>Backing field for <see cref="MatchValue" /> property.</summary>
        private string[] _matchValue;

        /// <summary>The match value for the condition of the delivery rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string[] MatchValue { get => this._matchValue; set => this._matchValue = value; }

        /// <summary>Internal Acessors for TypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICookiesMatchConditionParametersInternal.TypeName { get => this._typeName; set { {_typeName = value;} } }

        /// <summary>Backing field for <see cref="NegateCondition" /> property.</summary>
        private bool? _negateCondition;

        /// <summary>Describes if this is negate condition or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public bool? NegateCondition { get => this._negateCondition; set => this._negateCondition = value; }

        /// <summary>Backing field for <see cref="Operator" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CookiesOperator _operator;

        /// <summary>Describes operator to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CookiesOperator Operator { get => this._operator; set => this._operator = value; }

        /// <summary>Backing field for <see cref="Selector" /> property.</summary>
        private string _selector;

        /// <summary>Name of Cookies to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Selector { get => this._selector; set => this._selector = value; }

        /// <summary>Backing field for <see cref="Transform" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] _transform;

        /// <summary>List of transforms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] Transform { get => this._transform; set => this._transform = value; }

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName= @"DeliveryRuleCookiesConditionParameters";

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; }

        /// <summary>Creates an new <see cref="CookiesMatchConditionParameters" /> instance.</summary>
        public CookiesMatchConditionParameters()
        {

        }
    }
    /// Defines the parameters for Cookies match conditions
    public partial interface ICookiesMatchConditionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>The match value for the condition of the delivery rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The match value for the condition of the delivery rule",
        SerializedName = @"matchValues",
        PossibleTypes = new [] { typeof(string) })]
        string[] MatchValue { get; set; }
        /// <summary>Describes if this is negate condition or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Describes if this is negate condition or not",
        SerializedName = @"negateCondition",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NegateCondition { get; set; }
        /// <summary>Describes operator to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Describes operator to be matched",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CookiesOperator) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CookiesOperator Operator { get; set; }
        /// <summary>Name of Cookies to be matched</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Cookies to be matched",
        SerializedName = @"selector",
        PossibleTypes = new [] { typeof(string) })]
        string Selector { get; set; }
        /// <summary>List of transforms</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of transforms",
        SerializedName = @"transforms",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] Transform { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string TypeName { get;  }

    }
    /// Defines the parameters for Cookies match conditions
    internal partial interface ICookiesMatchConditionParametersInternal

    {
        /// <summary>The match value for the condition of the delivery rule</summary>
        string[] MatchValue { get; set; }
        /// <summary>Describes if this is negate condition or not</summary>
        bool? NegateCondition { get; set; }
        /// <summary>Describes operator to be matched</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CookiesOperator Operator { get; set; }
        /// <summary>Name of Cookies to be matched</summary>
        string Selector { get; set; }
        /// <summary>List of transforms</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Transform[] Transform { get; set; }

        string TypeName { get; set; }

    }
}