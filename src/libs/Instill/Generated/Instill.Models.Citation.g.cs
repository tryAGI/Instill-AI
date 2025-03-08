
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Citation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CitationType2JsonConverter))]
        public global::Instill.CitationType2? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkUid")]
        public global::System.Collections.Generic.IList<string>? ChunkUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUid")]
        public string? ObjectUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// Included only in responses
        /// </param>
        /// <param name="chunkUid">
        /// Included only in responses
        /// </param>
        /// <param name="fileUid">
        /// Included only in responses
        /// </param>
        /// <param name="objectUid">
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// Included only in responses
        /// </param>
        /// <param name="number">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Citation(
            global::Instill.CitationType2? type,
            string? name,
            string? url,
            global::System.Collections.Generic.IList<string>? chunkUid,
            string? fileUid,
            string? objectUid,
            string? summary,
            int? number)
        {
            this.Type = type;
            this.Name = name;
            this.Url = url;
            this.ChunkUid = chunkUid;
            this.FileUid = fileUid;
            this.ObjectUid = objectUid;
            this.Summary = summary;
            this.Number = number;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        public Citation()
        {
        }
    }
}