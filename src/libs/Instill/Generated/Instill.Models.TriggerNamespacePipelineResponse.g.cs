
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerNamespacePipelineResponse contains the pipeline execution results, i.e.,<br/>
    /// the multiple model inference outputs.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineResponse
    {
        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Instill.TriggerMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerNamespacePipelineResponse(
            global::System.Collections.Generic.IList<object>? outputs,
            global::Instill.TriggerMetadata? metadata)
        {
            this.Outputs = outputs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineResponse" /> class.
        /// </summary>
        public TriggerNamespacePipelineResponse()
        {
        }
    }
}