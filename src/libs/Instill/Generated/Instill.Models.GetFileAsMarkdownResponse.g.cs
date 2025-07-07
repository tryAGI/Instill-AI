
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetFileAsMarkdownResponse contains a blob with the Markdown representation<br/>
    /// of a file.
    /// </summary>
    public sealed partial class GetFileAsMarkdownResponse
    {
        /// <summary>
        /// The Markdown representation of a file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileAsMarkdownResponse" /> class.
        /// </summary>
        /// <param name="markdown">
        /// The Markdown representation of a file.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileAsMarkdownResponse(
            string? markdown)
        {
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileAsMarkdownResponse" /> class.
        /// </summary>
        public GetFileAsMarkdownResponse()
        {
        }
    }
}