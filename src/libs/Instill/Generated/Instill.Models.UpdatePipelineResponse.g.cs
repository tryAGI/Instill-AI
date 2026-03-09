
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdatePipelineResponse contains the updated pipeline.
    /// </summary>
    public sealed partial class UpdatePipelineResponse
    {
        /// <summary>
        /// The updated pipeline resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::Instill.Pipeline? Pipeline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePipelineResponse" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// The updated pipeline resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePipelineResponse(
            global::Instill.Pipeline? pipeline)
        {
            this.Pipeline = pipeline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePipelineResponse" /> class.
        /// </summary>
        public UpdatePipelineResponse()
        {
        }
    }
}