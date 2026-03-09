
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListKnowledgeBasesResponse represents a response for listing knowledge bases.
    /// </summary>
    public sealed partial class ListKnowledgeBasesResponse
    {
        /// <summary>
        /// The list of knowledge bases.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBases")]
        public global::System.Collections.Generic.IList<global::Instill.KnowledgeBase>? KnowledgeBases { get; set; }

        /// <summary>
        /// Next page token for pagination.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of knowledge bases matching the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKnowledgeBasesResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBases">
        /// The list of knowledge bases.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token for pagination.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of knowledge bases matching the request.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListKnowledgeBasesResponse(
            global::System.Collections.Generic.IList<global::Instill.KnowledgeBase>? knowledgeBases,
            string? nextPageToken,
            int? totalSize)
        {
            this.KnowledgeBases = knowledgeBases;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKnowledgeBasesResponse" /> class.
        /// </summary>
        public ListKnowledgeBasesResponse()
        {
        }
    }
}