
#nullable enable

namespace Instill
{
    /// <summary>
    /// Agent represents a agent.
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentUid")]
        public string? AgentUid { get; set; }

        /// <summary>
        /// The agent display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The agent description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The namespace of the agent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceUid")]
        public string? NamespaceUid { get; set; }

        /// <summary>
        /// The agent tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The agent metadata.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentMetadata")]
        public global::Instill.AIAgentAppMetadata? AiAgentMetadata { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// The creation time of the agent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// The last update time of the agent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="agentUid">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// The agent display name.
        /// </param>
        /// <param name="description">
        /// The agent description.
        /// </param>
        /// <param name="namespaceUid">
        /// The namespace of the agent.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// The agent tags.
        /// </param>
        /// <param name="aiAgentMetadata">
        /// The agent metadata.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorUid">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// The creation time of the agent.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The last update time of the agent.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Agent(
            string displayName,
            string? agentUid,
            string? description,
            string? namespaceUid,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.AIAgentAppMetadata? aiAgentMetadata,
            string? creatorUid,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.AgentUid = agentUid;
            this.Description = description;
            this.NamespaceUid = namespaceUid;
            this.Tags = tags;
            this.AiAgentMetadata = aiAgentMetadata;
            this.CreatorUid = creatorUid;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}