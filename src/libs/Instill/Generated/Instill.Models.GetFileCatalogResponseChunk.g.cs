
#nullable enable

namespace Instill
{
    /// <summary>
    /// Chunk is a delimited part of the converted text.
    /// </summary>
    public sealed partial class GetFileCatalogResponseChunk
    {
        /// <summary>
        /// Chunk UID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Chunk type. I.e: text, image, audio, video.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ChunkType2JsonConverter))]
        public global::Instill.ChunkType2? Type { get; set; }

        /// <summary>
        /// Start position in the text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPosition")]
        public int? StartPosition { get; set; }

        /// <summary>
        /// End position in the text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPosition")]
        public int? EndPosition { get; set; }

        /// <summary>
        /// Content.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Token count in the chunk.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Chunk embedding.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<float>? Embedding { get; set; }

        /// <summary>
        /// Creation time of the chunk.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Retrievability of the chunk.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponseChunk" /> class.
        /// </summary>
        /// <param name="uid">
        /// Chunk UID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Chunk type. I.e: text, image, audio, video.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startPosition">
        /// Start position in the text.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endPosition">
        /// End position in the text.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="content">
        /// Content.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenCount">
        /// Token count in the chunk.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="embedding">
        /// Chunk embedding.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Creation time of the chunk.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="retrievable">
        /// Retrievability of the chunk.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileCatalogResponseChunk(
            string? uid,
            global::Instill.ChunkType2? type,
            int? startPosition,
            int? endPosition,
            string? content,
            int? tokenCount,
            global::System.Collections.Generic.IList<float>? embedding,
            global::System.DateTime? createTime,
            bool? retrievable)
        {
            this.Uid = uid;
            this.Type = type;
            this.StartPosition = startPosition;
            this.EndPosition = endPosition;
            this.Content = content;
            this.TokenCount = tokenCount;
            this.Embedding = embedding;
            this.CreateTime = createTime;
            this.Retrievable = retrievable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponseChunk" /> class.
        /// </summary>
        public GetFileCatalogResponseChunk()
        {
        }
    }
}