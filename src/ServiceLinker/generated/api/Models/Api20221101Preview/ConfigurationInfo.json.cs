// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>
    /// The configuration information, used to generate configurations or save to applications
    /// </summary>
    public partial class ConfigurationInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject into a new instance of <see cref="ConfigurationInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConfigurationInfo(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_deleteOrUpdateBehavior = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonString>("deleteOrUpdateBehavior"), out var __jsonDeleteOrUpdateBehavior) ? (string)__jsonDeleteOrUpdateBehavior : (string)DeleteOrUpdateBehavior;}
            {_action = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonString>("action"), out var __jsonAction) ? (string)__jsonAction : (string)Action;}
            {_customizedKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject>("customizedKeys"), out var __jsonCustomizedKeys) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoCustomizedKeys.FromJson(__jsonCustomizedKeys) : CustomizedKey;}
            {_additionalConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject>("additionalConfigurations"), out var __jsonAdditionalConfigurations) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.ConfigurationInfoAdditionalConfigurations.FromJson(__jsonAdditionalConfigurations) : AdditionalConfiguration;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.Api20221101Preview.IConfigurationInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject json ? new ConfigurationInfo(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConfigurationInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConfigurationInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._deleteOrUpdateBehavior)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonString(this._deleteOrUpdateBehavior.ToString()) : null, "deleteOrUpdateBehavior" ,container.Add );
            AddIf( null != (((object)this._action)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonString(this._action.ToString()) : null, "action" ,container.Add );
            AddIf( null != this._customizedKey ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode) this._customizedKey.ToJson(null,serializationMode) : null, "customizedKeys" ,container.Add );
            AddIf( null != this._additionalConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Json.JsonNode) this._additionalConfiguration.ToJson(null,serializationMode) : null, "additionalConfigurations" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}