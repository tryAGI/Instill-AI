
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatWith")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ChatWithJsonConverter))]
        public global::Instill.ChatWith? ChatWith { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationDisplayName")]
        public string? ConversationDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentApp")]
        public global::Instill.AIAgentAppMetadata? AiAgentApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationBody" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="chatWith"></param>
        /// <param name="conversationDisplayName"></param>
        /// <param name="aiAgentApp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateConversationBody(
            string conversationId,
            global::Instill.ChatWith? chatWith,
            string? conversationDisplayName,
            global::Instill.AIAgentAppMetadata? aiAgentApp)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.ChatWith = chatWith;
            this.ConversationDisplayName = conversationDisplayName;
            this.AiAgentApp = aiAgentApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationBody" /> class.
        /// </summary>
        public CreateConversationBody()
        {
        }
    }
}