
#nullable enable

namespace Instill
{
    /// <summary>
    /// SimilarityChunk represents a chunk with similarity score.
    /// </summary>
    public sealed partial class SimilarityChunk
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk")]
        public string? Chunk { get; set; }

        /// <summary>
        /// Similarity score.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityScore")]
        public float? SimilarityScore { get; set; }

        /// <summary>
        /// Content.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textContent")]
        public string? TextContent { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public string? File { get; set; }

        /// <summary>
        /// Chunk metadata.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkMetadata")]
        public global::Instill.Chunk? ChunkMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunk" /> class.
        /// </summary>
        /// <param name="chunk">
        /// Included only in responses
        /// </param>
        /// <param name="similarityScore">
        /// Similarity score.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="textContent">
        /// Content.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="file">
        /// Included only in responses
        /// </param>
        /// <param name="chunkMetadata">
        /// Chunk metadata.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunk(
            string? chunk,
            float? similarityScore,
            string? textContent,
            string? file,
            global::Instill.Chunk? chunkMetadata)
        {
            this.Chunk = chunk;
            this.SimilarityScore = similarityScore;
            this.TextContent = textContent;
            this.File = file;
            this.ChunkMetadata = chunkMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunk" /> class.
        /// </summary>
        public SimilarityChunk()
        {
        }
    }
}