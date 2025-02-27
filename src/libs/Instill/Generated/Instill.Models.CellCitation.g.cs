
#nullable enable

namespace Instill
{
    /// <summary>
    /// The citations for the cell.
    /// </summary>
    public sealed partial class CellCitation
    {
        /// <summary>
        /// The type of the citation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CitationTypeJsonConverter))]
        public global::Instill.CitationType? Type { get; set; }

        /// <summary>
        /// The url of the citation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The title of the citation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The summary of the citation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CellCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the citation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The url of the citation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// The title of the citation.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// The summary of the citation.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CellCitation(
            global::Instill.CitationType? type,
            string? url,
            string? title,
            string? summary)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellCitation" /> class.
        /// </summary>
        public CellCitation()
        {
        }
    }
}