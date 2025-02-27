
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
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfig")]
        public global::Instill.AgentConfig? AgentConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        /// <param name="chatDisplayName"></param>
        /// <param name="agentConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChatBody(
            string? chatDisplayName,
            global::Instill.AgentConfig? agentConfig)
        {
            this.ChatDisplayName = chatDisplayName;
            this.AgentConfig = agentConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatBody" /> class.
        /// </summary>
        public UpdateChatBody()
        {
        }
    }
}