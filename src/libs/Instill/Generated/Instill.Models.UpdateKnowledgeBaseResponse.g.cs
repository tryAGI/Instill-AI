
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateKnowledgeBaseResponse represents a response for updating a knowledge<br/>
    /// base.
    /// </summary>
    public sealed partial class UpdateKnowledgeBaseResponse
    {
        /// <summary>
        /// The updated knowledge base resource.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateKnowledgeBaseResponse" /> class.
        /// </summary>
        /// <param name="knowledgeBase">
        /// The updated knowledge base resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKnowledgeBaseResponse(
            global::Instill.KnowledgeBase? knowledgeBase)
        {
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeBaseResponse" /> class.
        /// </summary>
        public UpdateKnowledgeBaseResponse()
        {
        }
    }
}