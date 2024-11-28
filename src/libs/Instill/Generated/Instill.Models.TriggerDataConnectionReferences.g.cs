
#nullable enable

namespace Instill
{
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
    public sealed partial class TriggerDataConnectionReferences
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerDataConnectionReferences" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerDataConnectionReferences(
 )
        {
        }
    }
}