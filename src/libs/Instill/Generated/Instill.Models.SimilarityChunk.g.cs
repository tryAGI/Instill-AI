
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunk
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkUid")]
        public string? ChunkUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityScore")]
        public float? SimilarityScore { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textContent")]
        public string? TextContent { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        public string? SourceFile { get; set; }

        /// <summary>
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
        /// <param name="chunkUid">
        /// Included only in responses
        /// </param>
        /// <param name="similarityScore">
        /// Included only in responses
        /// </param>
        /// <param name="textContent">
        /// Included only in responses
        /// </param>
        /// <param name="sourceFile">
        /// Included only in responses
        /// </param>
        /// <param name="chunkMetadata">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunk(
            string? chunkUid,
            float? similarityScore,
            string? textContent,
            string? sourceFile,
            global::Instill.Chunk? chunkMetadata)
        {
            this.ChunkUid = chunkUid;
            this.SimilarityScore = similarityScore;
            this.TextContent = textContent;
            this.SourceFile = sourceFile;
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