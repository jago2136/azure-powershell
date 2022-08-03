// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ListWorkspaceKeysResultTypeConverter))]
    public partial class ListWorkspaceKeysResult
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListWorkspaceKeysResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ListWorkspaceKeysResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListWorkspaceKeysResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ListWorkspaceKeysResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ListWorkspaceKeysResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ListWorkspaceKeysResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListWorkspaceKeysResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ListWorkspaceKeysResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContainerRegistryCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentials = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IRegistryListCredentialsResult) content.GetValueForProperty("ContainerRegistryCredentials",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentials, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.RegistryListCredentialsResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotebookAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKey = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListNotebookKeysResult) content.GetValueForProperty("NotebookAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKey, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListNotebookKeysResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserStorageKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageKey = (string) content.GetValueForProperty("UserStorageKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageKey, global::System.Convert.ToString);
            }
            if (content.Contains("UserStorageResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageResourceId = (string) content.GetValueForProperty("UserStorageResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AppInsightsInstrumentationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).AppInsightsInstrumentationKey = (string) content.GetValueForProperty("AppInsightsInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).AppInsightsInstrumentationKey, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsLocation = (string) content.GetValueForProperty("ContainerRegistryCredentialsLocation",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsUsername = (string) content.GetValueForProperty("ContainerRegistryCredentialsUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsPassword = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPassword[]) content.GetValueForProperty("ContainerRegistryCredentialsPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsPassword, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPassword>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.PasswordTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotebookAccessKeyPrimaryAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeyPrimaryAccessKey = (string) content.GetValueForProperty("NotebookAccessKeyPrimaryAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeyPrimaryAccessKey, global::System.Convert.ToString);
            }
            if (content.Contains("NotebookAccessKeySecondaryAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeySecondaryAccessKey = (string) content.GetValueForProperty("NotebookAccessKeySecondaryAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeySecondaryAccessKey, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListWorkspaceKeysResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ListWorkspaceKeysResult(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContainerRegistryCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentials = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IRegistryListCredentialsResult) content.GetValueForProperty("ContainerRegistryCredentials",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentials, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.RegistryListCredentialsResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotebookAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKey = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListNotebookKeysResult) content.GetValueForProperty("NotebookAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKey, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ListNotebookKeysResultTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserStorageKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageKey = (string) content.GetValueForProperty("UserStorageKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageKey, global::System.Convert.ToString);
            }
            if (content.Contains("UserStorageResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageResourceId = (string) content.GetValueForProperty("UserStorageResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).UserStorageResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AppInsightsInstrumentationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).AppInsightsInstrumentationKey = (string) content.GetValueForProperty("AppInsightsInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).AppInsightsInstrumentationKey, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsLocation = (string) content.GetValueForProperty("ContainerRegistryCredentialsLocation",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsUsername = (string) content.GetValueForProperty("ContainerRegistryCredentialsUsername",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerRegistryCredentialsPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsPassword = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPassword[]) content.GetValueForProperty("ContainerRegistryCredentialsPassword",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).ContainerRegistryCredentialsPassword, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPassword>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.PasswordTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotebookAccessKeyPrimaryAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeyPrimaryAccessKey = (string) content.GetValueForProperty("NotebookAccessKeyPrimaryAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeyPrimaryAccessKey, global::System.Convert.ToString);
            }
            if (content.Contains("NotebookAccessKeySecondaryAccessKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeySecondaryAccessKey = (string) content.GetValueForProperty("NotebookAccessKeySecondaryAccessKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListWorkspaceKeysResultInternal)this).NotebookAccessKeySecondaryAccessKey, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(ListWorkspaceKeysResultTypeConverter))]
    public partial interface IListWorkspaceKeysResult

    {

    }
}