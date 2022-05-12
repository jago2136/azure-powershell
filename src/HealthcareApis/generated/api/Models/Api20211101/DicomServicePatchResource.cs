// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>Dicom Service patch properties</summary>
    public partial class DicomServicePatchResource :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResource,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IDicomServicePatchResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1 __resourceTags1 = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ResourceTags1();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentity __serviceManagedIdentity = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServiceManagedIdentity();

        /// <summary>
        /// Setting indicating whether the service has a managed identity associated with it.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityAutoGenerated Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).Identity = value ?? null /* model class */; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityPrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityTenantId; }

        /// <summary>
        /// Type of identity being specified, currently SystemAssigned and None are allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.ServiceManagedIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityUserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal)__serviceManagedIdentity).IdentityTenantId = value; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)__resourceTags1).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal)__resourceTags1).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="DicomServicePatchResource" /> instance.</summary>
        public DicomServicePatchResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceTags1), __resourceTags1);
            await eventListener.AssertObjectIsValid(nameof(__resourceTags1), __resourceTags1);
            await eventListener.AssertNotNull(nameof(__serviceManagedIdentity), __serviceManagedIdentity);
            await eventListener.AssertObjectIsValid(nameof(__serviceManagedIdentity), __serviceManagedIdentity);
        }
    }
    /// Dicom Service patch properties
    public partial interface IDicomServicePatchResource :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentity
    {

    }
    /// Dicom Service patch properties
    internal partial interface IDicomServicePatchResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IResourceTags1Internal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceManagedIdentityInternal
    {

    }
}