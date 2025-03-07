
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatBody
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatBody" /> class.
        /// </summary>
        /// <param name="chatDisplayName"></param>
        /// <param name="agentConfig"></param>
        /// <param name="catalogId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatBody(
            string? chatDisplayName,
            global::Instill.AgentConfig? agentConfig,
            string? catalogId)
        {
            this.ChatDisplayName = chatDisplayName;
            this.AgentConfig = agentConfig;
            this.CatalogId = catalogId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatBody" /> class.
        /// </summary>
        public CreateChatBody()
        {
        }
    }
}