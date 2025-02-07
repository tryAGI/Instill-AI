
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerData contains the input data for a pipeline run.
    /// </summary>
    public sealed partial class TriggerData
    {
        /// <summary>
        /// The values of the pipeline variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        public object? Variable { get; set; }

        /// <summary>
        /// A collection of secrets. By default, if a pipeline references any secret<br/>
        /// (`${secret.&lt;id&gt;}`), its value is read from the namespace's secrets.<br/>
        /// This object provides a way to override these secret values: if one of its<br/>
        /// keys matches the ID of a reference secret, its value will be read from<br/>
        /// here instead of from the namespace secret collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secret { get; set; }

        /// <summary>
        /// A collection of connection references. By default, connection references<br/>
        /// (`${connection.&lt;id&gt;}`) in a pipeline will be resolved by fetching the<br/>
        /// value from the requester's connections. Connections contain sensitive data<br/>
        /// and can't be shared across namespaces, so this means that, in order to<br/>
        /// successfully run a pipeline owned by another namespace, the requester will<br/>
        /// need to have a connection with the same ID.<br/>
        /// This object provides a way to override the connection references with<br/>
        /// connections that the requester owns. Each element in the object maps a<br/>
        /// connection ID present in the pipeline (key) to the ID of a connection<br/>
        /// owned by the requester (value).<br/>
        /// Note that, since only references are accepted (this object shouldn't<br/>
        /// contain connection **values**), the reference syntax shouldn't be used<br/>
        /// here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionReferences")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConnectionReferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerData" /> class.
        /// </summary>
        /// <param name="variable">
        /// The values of the pipeline variables.
        /// </param>
        /// <param name="secret">
        /// A collection of secrets. By default, if a pipeline references any secret<br/>
        /// (`${secret.&lt;id&gt;}`), its value is read from the namespace's secrets.<br/>
        /// This object provides a way to override these secret values: if one of its<br/>
        /// keys matches the ID of a reference secret, its value will be read from<br/>
        /// here instead of from the namespace secret collection.
        /// </param>
        /// <param name="connectionReferences">
        /// A collection of connection references. By default, connection references<br/>
        /// (`${connection.&lt;id&gt;}`) in a pipeline will be resolved by fetching the<br/>
        /// value from the requester's connections. Connections contain sensitive data<br/>
        /// and can't be shared across namespaces, so this means that, in order to<br/>
        /// successfully run a pipeline owned by another namespace, the requester will<br/>
        /// need to have a connection with the same ID.<br/>
        /// This object provides a way to override the connection references with<br/>
        /// connections that the requester owns. Each element in the object maps a<br/>
        /// connection ID present in the pipeline (key) to the ID of a connection<br/>
        /// owned by the requester (value).<br/>
        /// Note that, since only references are accepted (this object shouldn't<br/>
        /// contain connection **values**), the reference syntax shouldn't be used<br/>
        /// here.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerData(
            object? variable,
            global::System.Collections.Generic.Dictionary<string, string>? secret,
            global::System.Collections.Generic.Dictionary<string, string>? connectionReferences)
        {
            this.Variable = variable;
            this.Secret = secret;
            this.ConnectionReferences = connectionReferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerData" /> class.
        /// </summary>
        public TriggerData()
        {
        }
    }
}