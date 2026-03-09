
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetChunkResponse represents a response for getting a chunk.
    /// </summary>
    public sealed partial class GetChunkResponse
    {
        /// <summary>
        /// The chunk metadata, including markdown_reference for extracting content.<br/>
        /// Clients should use GetFile to fetch the full content/summary markdown,<br/>
        /// then use markdown_reference coordinates to extract the specific chunk text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk")]
        public global::Instill.Chunk? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChunkResponse" /> class.
        /// </summary>
        /// <param name="chunk">
        /// The chunk metadata, including markdown_reference for extracting content.<br/>
        /// Clients should use GetFile to fetch the full content/summary markdown,<br/>
        /// then use markdown_reference coordinates to extract the specific chunk text.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChunkResponse(
            global::Instill.Chunk? chunk)
        {
            this.Chunk = chunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChunkResponse" /> class.
        /// </summary>
        public GetChunkResponse()
        {
        }
    }
}