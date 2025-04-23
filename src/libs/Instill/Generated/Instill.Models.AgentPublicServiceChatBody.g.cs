
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChatRequest represents a request to send a message<br/>
    /// to a chatbot synchronously and streams back the results.
    /// </summary>
    public sealed partial class AgentPublicServiceChatBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Whether to enable web search for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWebSearch")]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUids")]
        public global::System.Collections.Generic.IList<string>? ObjectUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPublicServiceChatBody" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fileUids"></param>
        /// <param name="enableWebSearch">
        /// Whether to enable web search for the chat.
        /// </param>
        /// <param name="objectUids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPublicServiceChatBody(
            string message,
            global::System.Collections.Generic.IList<string>? fileUids,
            bool? enableWebSearch,
            global::System.Collections.Generic.IList<string>? objectUids)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FileUids = fileUids;
            this.EnableWebSearch = enableWebSearch;
            this.ObjectUids = objectUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPublicServiceChatBody" /> class.
        /// </summary>
        public AgentPublicServiceChatBody()
        {
        }
    }
}