
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChatRequest represents a request to send a message<br/>
    /// to a chatbot synchronously and streams back the results.
    /// </summary>
    public sealed partial class AppPublicServiceChatBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmModel")]
        public string? LlmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userInstruction")]
        public string? UserInstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPublicServiceChatBody" /> class.
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="conversationUid"></param>
        /// <param name="message"></param>
        /// <param name="topK"></param>
        /// <param name="llmModel"></param>
        /// <param name="userInstruction"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppPublicServiceChatBody(
            string catalogId,
            string conversationUid,
            string message,
            long? topK,
            string? llmModel,
            string? userInstruction)
        {
            this.CatalogId = catalogId ?? throw new global::System.ArgumentNullException(nameof(catalogId));
            this.ConversationUid = conversationUid ?? throw new global::System.ArgumentNullException(nameof(conversationUid));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.TopK = topK;
            this.LlmModel = llmModel;
            this.UserInstruction = userInstruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPublicServiceChatBody" /> class.
        /// </summary>
        public AppPublicServiceChatBody()
        {
        }
    }
}