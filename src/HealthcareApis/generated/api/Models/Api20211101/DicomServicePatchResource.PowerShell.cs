// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.PowerShell;

    /// <summary>Dicom Service patch properties</summary>
    [System.ComponentModel.TypeConverter(typeof(DicomServicePatchResourceTypeConverter))]
    public partial class DicomServicePatchResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.DicomServicePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DicomServicePatchResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.DicomServicePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DicomServicePatchResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.DicomServicePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DicomServicePatchResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityAutoGenerated) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServiceManagedIdentityAutoGeneratedTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.DicomServicePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DicomServicePatchResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType.CreateFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityAutoGenerated) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServiceManagedIdentityAutoGeneratedTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DicomServicePatchResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Dicom Service patch properties
    [System.ComponentModel.TypeConverter(typeof(DicomServicePatchResourceTypeConverter))]
    public partial interface IDicomServicePatchResource

    {

    }
}