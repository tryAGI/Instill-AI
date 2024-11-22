
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newConversationId")]
        public string? NewConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedCatalogUid")]
        public string? LastUsedCatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedTopK")]
        public long? LastUsedTopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentApp")]
        public global::Instill.AIAgentAppMetadata? AiAgentApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationDisplayName")]
        public string? ConversationDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        /// <param name="newConversationId"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        /// <param name="aiAgentApp"></param>
        /// <param name="conversationDisplayName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateConversationBody(
            string? newConversationId,
            string? lastUsedCatalogUid,
            long? lastUsedTopK,
            global::Instill.AIAgentAppMetadata? aiAgentApp,
            string? conversationDisplayName)
        {
            this.NewConversationId = newConversationId;
            this.LastUsedCatalogUid = lastUsedCatalogUid;
            this.LastUsedTopK = lastUsedTopK;
            this.AiAgentApp = aiAgentApp;
            this.ConversationDisplayName = conversationDisplayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        public UpdateConversationBody()
        {
        }
    }
}