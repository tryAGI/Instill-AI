
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
        /// The reranker that produced the scores in `similar_chunks`. Read<br/>
        /// this before applying any score threshold — see the `Ranker` enum<br/>
        /// for why.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.RankerJsonConverter))]
        public global::Instill.Ranker? Ranker { get; set; }

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
        /// <param name="ranker">
        /// The reranker that produced the scores in `similar_chunks`. Read<br/>
        /// this before applying any score threshold — see the `Ranker` enum<br/>
        /// for why.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchChunksResponse(
            global::System.Collections.Generic.IList<global::Instill.SimilarityChunk>? similarChunks,
            global::Instill.Ranker? ranker)
        {
            this.SimilarChunks = similarChunks;
            this.Ranker = ranker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksResponse" /> class.
        /// </summary>
        public SearchChunksResponse()
        {
        }
    }
}