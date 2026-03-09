
#nullable enable

namespace Instill
{
    /// <summary>
    /// SearchChunksResponse represents a response for searching similar chunks.
    /// </summary>
    public sealed partial class SearchChunksResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarChunks")]
        public global::System.Collections.Generic.IList<global::Instill.SimilarityChunk>? SimilarChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksResponse" /> class.
        /// </summary>
        /// <param name="similarChunks">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchChunksResponse(
            global::System.Collections.Generic.IList<global::Instill.SimilarityChunk>? similarChunks)
        {
            this.SimilarChunks = similarChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksResponse" /> class.
        /// </summary>
        public SearchChunksResponse()
        {
        }
    }
}