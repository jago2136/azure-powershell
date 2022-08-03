// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    public partial class SpringCloudIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentityInternal
    {

        /// <summary>Backing field for <see cref="AgentPoolName" /> property.</summary>
        private string _agentPoolName;

        /// <summary>The name of the build service agent pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string AgentPoolName { get => this._agentPoolName; set => this._agentPoolName = value; }

        /// <summary>Backing field for <see cref="AppName" /> property.</summary>
        private string _appName;

        /// <summary>The name of the App resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string AppName { get => this._appName; set => this._appName = value; }

        /// <summary>Backing field for <see cref="BindingName" /> property.</summary>
        private string _bindingName;

        /// <summary>The name of the Binding resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BindingName { get => this._bindingName; set => this._bindingName = value; }

        /// <summary>Backing field for <see cref="BuildName" /> property.</summary>
        private string _buildName;

        /// <summary>The name of the build resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuildName { get => this._buildName; set => this._buildName = value; }

        /// <summary>Backing field for <see cref="BuildResultName" /> property.</summary>
        private string _buildResultName;

        /// <summary>The name of the build result resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuildResultName { get => this._buildResultName; set => this._buildResultName = value; }

        /// <summary>Backing field for <see cref="BuildServiceName" /> property.</summary>
        private string _buildServiceName;

        /// <summary>The name of the build service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuildServiceName { get => this._buildServiceName; set => this._buildServiceName = value; }

        /// <summary>Backing field for <see cref="BuilderName" /> property.</summary>
        private string _builderName;

        /// <summary>The name of the builder resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuilderName { get => this._builderName; set => this._builderName = value; }

        /// <summary>Backing field for <see cref="BuildpackBindingName" /> property.</summary>
        private string _buildpackBindingName;

        /// <summary>The name of the Buildpack Binding Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuildpackBindingName { get => this._buildpackBindingName; set => this._buildpackBindingName = value; }

        /// <summary>Backing field for <see cref="BuildpackName" /> property.</summary>
        private string _buildpackName;

        /// <summary>The name of the buildpack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string BuildpackName { get => this._buildpackName; set => this._buildpackName = value; }

        /// <summary>Backing field for <see cref="CertificateName" /> property.</summary>
        private string _certificateName;

        /// <summary>The name of the certificate resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string CertificateName { get => this._certificateName; set => this._certificateName = value; }

        /// <summary>Backing field for <see cref="ConfigurationServiceName" /> property.</summary>
        private string _configurationServiceName;

        /// <summary>The name of Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ConfigurationServiceName { get => this._configurationServiceName; set => this._configurationServiceName = value; }

        /// <summary>Backing field for <see cref="DeploymentName" /> property.</summary>
        private string _deploymentName;

        /// <summary>The name of the Deployment resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string DeploymentName { get => this._deploymentName; set => this._deploymentName = value; }

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>The name of the custom domain resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string DomainName { get => this._domainName; set => this._domainName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>the region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="ServiceName" /> property.</summary>
        private string _serviceName;

        /// <summary>The name of the Service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ServiceName { get => this._serviceName; set => this._serviceName = value; }

        /// <summary>Backing field for <see cref="ServiceRegistryName" /> property.</summary>
        private string _serviceRegistryName;

        /// <summary>The name of Service Registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string ServiceRegistryName { get => this._serviceRegistryName; set => this._serviceRegistryName = value; }

        /// <summary>Backing field for <see cref="StackName" /> property.</summary>
        private string _stackName;

        /// <summary>The name of the stack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string StackName { get => this._stackName; set => this._stackName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="SpringCloudIdentity" /> instance.</summary>
        public SpringCloudIdentity()
        {

        }
    }
    public partial interface ISpringCloudIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>The name of the build service agent pool resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the build service agent pool resource.",
        SerializedName = @"agentPoolName",
        PossibleTypes = new [] { typeof(string) })]
        string AgentPoolName { get; set; }
        /// <summary>The name of the App resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the App resource.",
        SerializedName = @"appName",
        PossibleTypes = new [] { typeof(string) })]
        string AppName { get; set; }
        /// <summary>The name of the Binding resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Binding resource.",
        SerializedName = @"bindingName",
        PossibleTypes = new [] { typeof(string) })]
        string BindingName { get; set; }
        /// <summary>The name of the build resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the build resource.",
        SerializedName = @"buildName",
        PossibleTypes = new [] { typeof(string) })]
        string BuildName { get; set; }
        /// <summary>The name of the build result resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the build result resource.",
        SerializedName = @"buildResultName",
        PossibleTypes = new [] { typeof(string) })]
        string BuildResultName { get; set; }
        /// <summary>The name of the build service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the build service resource.",
        SerializedName = @"buildServiceName",
        PossibleTypes = new [] { typeof(string) })]
        string BuildServiceName { get; set; }
        /// <summary>The name of the builder resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the builder resource.",
        SerializedName = @"builderName",
        PossibleTypes = new [] { typeof(string) })]
        string BuilderName { get; set; }
        /// <summary>The name of the Buildpack Binding Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Buildpack Binding Name",
        SerializedName = @"buildpackBindingName",
        PossibleTypes = new [] { typeof(string) })]
        string BuildpackBindingName { get; set; }
        /// <summary>The name of the buildpack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the buildpack resource.",
        SerializedName = @"buildpackName",
        PossibleTypes = new [] { typeof(string) })]
        string BuildpackName { get; set; }
        /// <summary>The name of the certificate resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the certificate resource.",
        SerializedName = @"certificateName",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateName { get; set; }
        /// <summary>The name of Application Configuration Service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of Application Configuration Service.",
        SerializedName = @"configurationServiceName",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationServiceName { get; set; }
        /// <summary>The name of the Deployment resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Deployment resource.",
        SerializedName = @"deploymentName",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentName { get; set; }
        /// <summary>The name of the custom domain resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the custom domain resource.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>the region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the region",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The name of the Service resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the Service resource.",
        SerializedName = @"serviceName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceName { get; set; }
        /// <summary>The name of Service Registry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of Service Registry.",
        SerializedName = @"serviceRegistryName",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceRegistryName { get; set; }
        /// <summary>The name of the stack resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the stack resource.",
        SerializedName = @"stackName",
        PossibleTypes = new [] { typeof(string) })]
        string StackName { get; set; }
        /// <summary>
        /// Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface ISpringCloudIdentityInternal

    {
        /// <summary>The name of the build service agent pool resource.</summary>
        string AgentPoolName { get; set; }
        /// <summary>The name of the App resource.</summary>
        string AppName { get; set; }
        /// <summary>The name of the Binding resource.</summary>
        string BindingName { get; set; }
        /// <summary>The name of the build resource.</summary>
        string BuildName { get; set; }
        /// <summary>The name of the build result resource.</summary>
        string BuildResultName { get; set; }
        /// <summary>The name of the build service resource.</summary>
        string BuildServiceName { get; set; }
        /// <summary>The name of the builder resource.</summary>
        string BuilderName { get; set; }
        /// <summary>The name of the Buildpack Binding Name</summary>
        string BuildpackBindingName { get; set; }
        /// <summary>The name of the buildpack resource.</summary>
        string BuildpackName { get; set; }
        /// <summary>The name of the certificate resource.</summary>
        string CertificateName { get; set; }
        /// <summary>The name of Application Configuration Service.</summary>
        string ConfigurationServiceName { get; set; }
        /// <summary>The name of the Deployment resource.</summary>
        string DeploymentName { get; set; }
        /// <summary>The name of the custom domain resource.</summary>
        string DomainName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>the region</summary>
        string Location { get; set; }
        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API
        /// or the portal.
        /// </summary>
        string ResourceGroupName { get; set; }
        /// <summary>The name of the Service resource.</summary>
        string ServiceName { get; set; }
        /// <summary>The name of Service Registry.</summary>
        string ServiceRegistryName { get; set; }
        /// <summary>The name of the stack resource.</summary>
        string StackName { get; set; }
        /// <summary>
        /// Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI
        /// for every service call.
        /// </summary>
        string SubscriptionId { get; set; }

    }
}