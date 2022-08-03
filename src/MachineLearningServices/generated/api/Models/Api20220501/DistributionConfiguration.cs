// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Base definition for job distribution configuration.</summary>
    public partial class DistributionConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDistributionConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDistributionConfigurationInternal
    {

        /// <summary>Backing field for <see cref="DistributionType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType _distributionType;

        /// <summary>[Required] Specifies the type of distribution framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType DistributionType { get => this._distributionType; set => this._distributionType = value; }

        /// <summary>Creates an new <see cref="DistributionConfiguration" /> instance.</summary>
        public DistributionConfiguration()
        {

        }
    }
    /// Base definition for job distribution configuration.
    public partial interface IDistributionConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>[Required] Specifies the type of distribution framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] Specifies the type of distribution framework.",
        SerializedName = @"distributionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType DistributionType { get; set; }

    }
    /// Base definition for job distribution configuration.
    internal partial interface IDistributionConfigurationInternal

    {
        /// <summary>[Required] Specifies the type of distribution framework.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DistributionType DistributionType { get; set; }

    }
}