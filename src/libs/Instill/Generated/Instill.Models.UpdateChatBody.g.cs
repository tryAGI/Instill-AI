
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChatBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatDisplayName")]
        public string? ChatDisplayName { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        /// <param name="chatDisplayName"></param>
        /// <param name="aiAgentApp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateChatBody(
            string? chatDisplayName,
            global::Instill.AIAgentAppMetadata? aiAgentApp)
        {
            this.ChatDisplayName = chatDisplayName;
            this.AiAgentApp = aiAgentApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        public UpdateChatBody()
        {
        }
    }
}