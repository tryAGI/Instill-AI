
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
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentSettings")]
        public global::Instill.AIAgentSettings? AiAgentSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        /// <param name="chatDisplayName"></param>
        /// <param name="aiAgentSettings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateChatBody(
            string? chatDisplayName,
            global::Instill.AIAgentSettings? aiAgentSettings)
        {
            this.ChatDisplayName = chatDisplayName;
            this.AiAgentSettings = aiAgentSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        public UpdateChatBody()
        {
        }
    }
}