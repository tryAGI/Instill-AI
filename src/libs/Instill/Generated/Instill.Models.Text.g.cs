
#nullable enable

namespace Instill
{
    /// <summary>
    /// Text contains the text representation of the file.
    /// </summary>
    public sealed partial class Text
    {
        /// <summary>
        /// Pipelines used to process the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        public global::System.Collections.Generic.IList<string>? Pipelines { get; set; }

        /// <summary>
        /// Text representation of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Chunk count in the text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkCount")]
        public int? ChunkCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Last update timestamp for the text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Text" /> class.
        /// </summary>
        /// <param name="pipelines">
        /// Pipelines used to process the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="content">
        /// Text representation of the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="chunkCount">
        /// Chunk count in the text.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenCount">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Last update timestamp for the text.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Text(
            global::System.Collections.Generic.IList<string>? pipelines,
            string? content,
            int? chunkCount,
            int? tokenCount,
            global::System.DateTime? updateTime)
        {
            this.Pipelines = pipelines;
            this.Content = content;
            this.ChunkCount = chunkCount;
            this.TokenCount = tokenCount;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Text" /> class.
        /// </summary>
        public Text()
        {
        }
    }
}