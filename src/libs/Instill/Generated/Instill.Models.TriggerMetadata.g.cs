
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerMetadata contains the traces of the pipeline inference.
    /// </summary>
    public sealed partial class TriggerMetadata
    {
        /// <summary>
        /// Each key in the `traces` object is a component ID. The value is a Trace<br/>
        /// object containing the execution details.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.Trace>? Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerMetadata" /> class.
        /// </summary>
        /// <param name="traces">
        /// Each key in the `traces` object is a component ID. The value is a Trace<br/>
        /// object containing the execution details.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerMetadata(
            global::System.Collections.Generic.Dictionary<string, global::Instill.Trace>? traces)
        {
            this.Traces = traces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerMetadata" /> class.
        /// </summary>
        public TriggerMetadata()
        {
        }
    }
}