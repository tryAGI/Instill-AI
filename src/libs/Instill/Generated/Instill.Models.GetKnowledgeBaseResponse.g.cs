
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetKnowledgeBaseResponse represents a response for getting a knowledge base.
    /// </summary>
    public sealed partial class GetKnowledgeBaseResponse
    {
        /// <summary>
        /// The knowledge base resource.<br/>
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
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBase">
        /// The knowledge base resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseResponse(
            global::Instill.KnowledgeBase? knowledgeBase)
        {
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseResponse" /> class.
        /// </summary>
        public GetKnowledgeBaseResponse()
        {
        }
    }
}