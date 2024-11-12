
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkUid")]
        public string? ChunkUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarityScore")]
        public float? SimilarityScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textContent")]
        public string? TextContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        public string? SourceFile { get; set; }

        /// <summary>
        /// 
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
        /// <param name="chunkUid"></param>
        /// <param name="similarityScore"></param>
        /// <param name="textContent"></param>
        /// <param name="sourceFile"></param>
        /// <param name="chunkMetadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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