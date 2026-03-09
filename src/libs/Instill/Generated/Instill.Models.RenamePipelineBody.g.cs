
#nullable enable

namespace Instill
{
    /// <summary>
    /// RenamePipelineRequest represents a request to rename the name of a<br/>
    /// pipeline owned by a namespace.
    /// </summary>
    public sealed partial class RenamePipelineBody
    {
        /// <summary>
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace}/pipelines/{new_pipeline_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newPipelineId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenamePipelineBody" /> class.
        /// </summary>
        /// <param name="newPipelineId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace}/pipelines/{new_pipeline_id}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenamePipelineBody(
            string newPipelineId)
        {
            this.NewPipelineId = newPipelineId ?? throw new global::System.ArgumentNullException(nameof(newPipelineId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenamePipelineBody" /> class.
        /// </summary>
        public RenamePipelineBody()
        {
        }
    }
}