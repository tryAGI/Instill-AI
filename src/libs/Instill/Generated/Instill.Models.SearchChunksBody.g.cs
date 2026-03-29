
#nullable enable

namespace Instill
{
    /// <summary>
    /// SearchChunksRequest represents a request to search for similar chunks.
    /// </summary>
    public sealed partial class SearchChunksBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBase")]
        public string? KnowledgeBase { get; set; }

        /// <summary>
        /// Text prompt to look for similarities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Top K. Default value: 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// Chunk type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ChunkTypeJsonConverter))]
        public global::Instill.ChunkType? Type { get; set; }

        /// <summary>
        /// File media type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileMediaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileMediaTypeJsonConverter))]
        public global::Instill.FileMediaType? FileMediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// Tags to filter by. When multiple tags are provided, OR logic is applied.<br/>
        /// Note: File filter takes precedence over tags, as tags apply to files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksBody" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Text prompt to look for similarities.
        /// </param>
        /// <param name="knowledgeBase"></param>
        /// <param name="topK">
        /// Top K. Default value: 5.
        /// </param>
        /// <param name="type">
        /// Chunk type.
        /// </param>
        /// <param name="fileMediaType">
        /// File media type.
        /// </param>
        /// <param name="files"></param>
        /// <param name="tags">
        /// Tags to filter by. When multiple tags are provided, OR logic is applied.<br/>
        /// Note: File filter takes precedence over tags, as tags apply to files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchChunksBody(
            string textPrompt,
            string? knowledgeBase,
            long? topK,
            global::Instill.ChunkType? type,
            global::Instill.FileMediaType? fileMediaType,
            global::System.Collections.Generic.IList<string>? files,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.KnowledgeBase = knowledgeBase;
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.TopK = topK;
            this.Type = type;
            this.FileMediaType = fileMediaType;
            this.Files = files;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChunksBody" /> class.
        /// </summary>
        public SearchChunksBody()
        {
        }
    }
}