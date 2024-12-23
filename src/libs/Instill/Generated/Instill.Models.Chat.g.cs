
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NamespaceId { get; set; }

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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentMetadata")]
        public global::Instill.AIAgentAppMetadata? AiAgentMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempCatalogId")]
        public string? TempCatalogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatDisplayName")]
        public string? ChatDisplayName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakpoint")]
        public string? Breakpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        /// <param name="uid">
        /// Included only in responses
        /// </param>
        /// <param name="namespaceId"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        /// <param name="aiAgentMetadata">
        /// Included only in responses
        /// </param>
        /// <param name="tempCatalogId"></param>
        /// <param name="chatDisplayName"></param>
        /// <param name="breakpoint">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Chat(
            string namespaceId,
            string? uid,
            string? lastUsedCatalogUid,
            long? lastUsedTopK,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::Instill.AIAgentAppMetadata? aiAgentMetadata,
            string? tempCatalogId,
            string? chatDisplayName,
            string? breakpoint)
        {
            this.NamespaceId = namespaceId ?? throw new global::System.ArgumentNullException(nameof(namespaceId));
            this.Uid = uid;
            this.LastUsedCatalogUid = lastUsedCatalogUid;
            this.LastUsedTopK = lastUsedTopK;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.AiAgentMetadata = aiAgentMetadata;
            this.TempCatalogId = tempCatalogId;
            this.ChatDisplayName = chatDisplayName;
            this.Breakpoint = breakpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chat" /> class.
        /// </summary>
        public Chat()
        {
        }
    }
}