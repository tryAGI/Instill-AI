
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// unique identifier of the conversation created by the system.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// namespace id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NamespaceId { get; set; }

        /// <summary>
        /// conversation display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatDisplayName")]
        public string? ChatDisplayName { get; set; }

        /// <summary>
        /// agent config.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfig")]
        public global::Instill.AgentConfig? AgentConfig { get; set; }

        /// <summary>
        /// chat create time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// chat update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// chat delete time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="uid">
        /// unique identifier of the conversation created by the system.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="namespaceId">
        /// namespace id.
        /// </param>
        /// <param name="chatDisplayName">
        /// conversation display name.
        /// </param>
        /// <param name="agentConfig">
        /// agent config.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// chat create time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// chat update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// chat delete time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogId">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Chat(
            string namespaceId,
            string? uid,
            string? chatDisplayName,
            global::Instill.AgentConfig? agentConfig,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            string? catalogId)
        {
            this.NamespaceId = namespaceId ?? throw new global::System.ArgumentNullException(nameof(namespaceId));
            this.Uid = uid;
            this.ChatDisplayName = chatDisplayName;
            this.AgentConfig = agentConfig;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.CatalogId = catalogId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        public Chat()
        {
        }
    }
}