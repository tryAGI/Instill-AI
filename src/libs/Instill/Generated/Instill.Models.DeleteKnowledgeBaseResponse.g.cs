
#nullable enable

namespace Instill
{
    /// <summary>
    /// DeleteKnowledgeBaseResponse represents a response for deleting a knowledge<br/>
    /// base.
    /// </summary>
    public sealed partial class DeleteKnowledgeBaseResponse
    {
        /// <summary>
        /// The deleted knowledge base resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBase")]
        public global::Instill.KnowledgeBase? KnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteKnowledgeBaseResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBase">
        /// The deleted knowledge base resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteKnowledgeBaseResponse(
            global::Instill.KnowledgeBase? knowledgeBase)
        {
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteKnowledgeBaseResponse" /> class.
        /// </summary>
        public DeleteKnowledgeBaseResponse()
        {
        }
    }
}