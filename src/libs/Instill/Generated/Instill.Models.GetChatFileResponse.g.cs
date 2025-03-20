
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChatFileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public byte[]? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatFileResponse" /> class.
        /// </summary>
        /// <param name="markdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChatFileResponse(
            byte[]? markdown)
        {
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatFileResponse" /> class.
        /// </summary>
        public GetChatFileResponse()
        {
        }
    }
}