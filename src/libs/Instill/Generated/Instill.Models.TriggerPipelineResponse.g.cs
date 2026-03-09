
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerPipelineResponse contains the pipeline execution results,<br/>
    /// i.e., the multiple model inference outputs.
    /// </summary>
    public sealed partial class TriggerPipelineResponse
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
        /// Initializes a new instance of the <see cref="TriggerPipelineResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerPipelineResponse(
            global::System.Collections.Generic.IList<object>? outputs,
            global::Instill.TriggerMetadata? metadata)
        {
            this.Outputs = outputs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerPipelineResponse" /> class.
        /// </summary>
        public TriggerPipelineResponse()
        {
        }
    }
}