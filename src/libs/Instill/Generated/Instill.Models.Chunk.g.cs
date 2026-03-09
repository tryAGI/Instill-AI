
#nullable enable

namespace Instill
{
    /// <summary>
    /// The Chunk message represents a chunk of data in the artifact system.
    /// </summary>
    public sealed partial class Chunk
    {
        /// <summary>
        /// Field 1: The resource name of the chunk.<br/>
        /// Format:<br/>
        /// `namespaces/{namespace}/knowledge-bases/{knowledge_base}/files/{file}/chunks/{chunk}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Field 2: The chunk id (unique identifier).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("originalFile")]
        public string? OriginalFile { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        /// <param name="name">
        /// Field 1: The resource name of the chunk.<br/>
        /// Format:<br/>
        /// `namespaces/{namespace}/knowledge-bases/{knowledge_base}/files/{file}/chunks/{chunk}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Field 2: The chunk id (unique identifier).<br/>
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
        /// <param name="originalFile">
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chunk(
            string? name,
            string? id,
            bool? retrievable,
            long? tokens,
            global::System.DateTime? createTime,
            string? originalFile,
            global::Instill.ChunkType? type,
            global::Instill.Reference? reference,
            global::Instill.Reference? markdownReference)
        {
            this.Name = name;
            this.Id = id;
            this.Retrievable = retrievable;
            this.Tokens = tokens;
            this.CreateTime = createTime;
            this.OriginalFile = originalFile;
            this.Type = type;
            this.Reference = reference;
            this.MarkdownReference = markdownReference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chunk" /> class.
        /// </summary>
        public Chunk()
        {
        }
    }
}