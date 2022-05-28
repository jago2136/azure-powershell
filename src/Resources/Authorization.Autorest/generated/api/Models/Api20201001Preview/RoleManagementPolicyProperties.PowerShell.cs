// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.PowerShell;

    /// <summary>Role management policy properties with scope.</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyPropertiesTypeConverter))]
    public partial class RoleManagementPolicyProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleManagementPolicyProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleManagementPolicyProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleManagementPolicyProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RoleManagementPolicyProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleManagementPolicyProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyProperties) content.GetValueForProperty("PolicyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("IsOrganizationDefault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).IsOrganizationDefault = (bool?) content.GetValueForProperty("IsOrganizationDefault",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).IsOrganizationDefault, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastModifiedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Rule = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Rule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("EffectiveRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).EffectiveRule = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]) content.GetValueForProperty("EffectiveRule",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).EffectiveRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope) content.GetValueForProperty("PolicyPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastModifiedById"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedById, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleManagementPolicyProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyProperties) content.GetValueForProperty("PolicyProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("IsOrganizationDefault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).IsOrganizationDefault = (bool?) content.GetValueForProperty("IsOrganizationDefault",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).IsOrganizationDefault, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastModifiedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("LastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Rule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Rule = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]) content.GetValueForProperty("Rule",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).Rule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("EffectiveRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).EffectiveRule = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule[]) content.GetValueForProperty("EffectiveRule",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).EffectiveRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PolicyPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyPropertiesScope) content.GetValueForProperty("PolicyPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).PolicyPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastModifiedById"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedById, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyPropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Role management policy properties with scope.
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyPropertiesTypeConverter))]
    public partial interface IRoleManagementPolicyProperties

    {

    }
}