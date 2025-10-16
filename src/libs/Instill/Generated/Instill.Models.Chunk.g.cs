
#nullable enable

namespace Instill
{
    /// <summary>
    /// The Chunk message represents a chunk of data in the artifact system.
    /// </summary>
    public sealed partial class Chunk
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkUid")]
        public string? ChunkUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public long? Tokens { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalFileUid")]
        public string? OriginalFileUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ChunkTypeJsonConverter))]
        public global::Instill.ChunkType? Type { get; set; }

        /// <summary>
        /// Reference to the position of the chunk within the original file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference")]
        public global::Instill.Reference? Reference { get; set; }

        /// <summary>
        /// Reference to the position of the chunk within the Markdown (source) file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdownReference")]
        public global::Instill.Reference? MarkdownReference { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPos")]
        public long? StartPos { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPos")]
        public long? EndPos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        /// <param name="chunkUid">
        /// Included only in responses
        /// </param>
        /// <param name="retrievable">
        /// Included only in responses
        /// </param>
        /// <param name="tokens">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="originalFileUid">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Included only in responses
        /// </param>
        /// <param name="reference">
        /// Reference to the position of the chunk within the original file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="markdownReference">
        /// Reference to the position of the chunk within the Markdown (source) file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startPos">
        /// Included only in responses
        /// </param>
        /// <param name="endPos">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chunk(
            string? chunkUid,
            bool? retrievable,
            long? tokens,
            global::System.DateTime? createTime,
            string? originalFileUid,
            global::Instill.ChunkType? type,
            global::Instill.Reference? reference,
            global::Instill.Reference? markdownReference,
            long? startPos,
            long? endPos)
        {
            this.ChunkUid = chunkUid;
            this.Retrievable = retrievable;
            this.Tokens = tokens;
            this.CreateTime = createTime;
            this.OriginalFileUid = originalFileUid;
            this.Type = type;
            this.Reference = reference;
            this.MarkdownReference = markdownReference;
            this.StartPos = startPos;
            this.EndPos = endPos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        public Chunk()
        {
        }
    }
}