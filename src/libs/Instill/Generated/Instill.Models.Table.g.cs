
#nullable enable

namespace Instill
{
    /// <summary>
    /// Table represents a table resource.
    /// </summary>
    public sealed partial class Table
    {
        /// <summary>
        /// The unique identifier of the table.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The title of the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A description of the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional metadata associated with the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The timestamp when the table was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// The timestamp when the table was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The configuration for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.TableAgentConfig AgentConfig { get; set; }

        /// <summary>
        /// Whether to enable draft mode for the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draftMode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DraftMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the table.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// The title of the table.
        /// </param>
        /// <param name="description">
        /// A description of the table.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the table.
        /// </param>
        /// <param name="createTime">
        /// The timestamp when the table was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The timestamp when the table was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="agentConfig">
        /// The configuration for the agent.
        /// </param>
        /// <param name="draftMode">
        /// Whether to enable draft mode for the table.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Table(
            string title,
            global::Instill.TableAgentConfig agentConfig,
            bool draftMode,
            string? uid,
            string? description,
            object? metadata,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.AgentConfig = agentConfig ?? throw new global::System.ArgumentNullException(nameof(agentConfig));
            this.DraftMode = draftMode;
            this.Uid = uid;
            this.Description = description;
            this.Metadata = metadata;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table" /> class.
        /// </summary>
        public Table()
        {
        }
    }
}