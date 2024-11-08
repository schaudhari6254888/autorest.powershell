namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The updatable properties of the DeviceGroup.</summary>
    public partial class DeviceGroupUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject into a new instance of <see cref="DeviceGroupUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DeviceGroupUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_oSFeedType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("osFeedType"), out var __jsonOSFeedType) ? (string)__jsonOSFeedType : (string)_oSFeedType;}
            {_updatePolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("updatePolicy"), out var __jsonUpdatePolicy) ? (string)__jsonUpdatePolicy : (string)_updatePolicy;}
            {_allowCrashDumpsCollection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("allowCrashDumpsCollection"), out var __jsonAllowCrashDumpsCollection) ? (string)__jsonAllowCrashDumpsCollection : (string)_allowCrashDumpsCollection;}
            {_regionalDataBoundary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("regionalDataBoundary"), out var __jsonRegionalDataBoundary) ? (string)__jsonRegionalDataBoundary : (string)_regionalDataBoundary;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceGroupUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json ? new DeviceGroupUpdateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DeviceGroupUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DeviceGroupUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._oSFeedType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._oSFeedType.ToString()) : null, "osFeedType" ,container.Add );
            AddIf( null != (((object)this._updatePolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._updatePolicy.ToString()) : null, "updatePolicy" ,container.Add );
            AddIf( null != (((object)this._allowCrashDumpsCollection)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._allowCrashDumpsCollection.ToString()) : null, "allowCrashDumpsCollection" ,container.Add );
            AddIf( null != (((object)this._regionalDataBoundary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._regionalDataBoundary.ToString()) : null, "regionalDataBoundary" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}