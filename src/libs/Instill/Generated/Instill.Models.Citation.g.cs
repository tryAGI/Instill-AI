
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CitationTypeJsonConverter))]
        public global::Instill.CitationType? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public long? Number { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CitationExtractMethodTypeJsonConverter))]
        public global::Instill.CitationExtractMethodType? ExtractMethod { get; set; }

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
        /// <param name="number">
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// Included only in responses
        /// </param>
        /// <param name="extractMethod">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Citation(
            global::Instill.CitationType? type,
            string? name,
            string? url,
            long? number,
            string? summary,
            global::Instill.CitationExtractMethodType? extractMethod)
        {
            this.Type = type;
            this.Name = name;
            this.Url = url;
            this.Number = number;
            this.Summary = summary;
            this.ExtractMethod = extractMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Citation" /> class.
        /// </summary>
        public Citation()
        {
        }
    }
}