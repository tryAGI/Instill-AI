
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBase
    {
        /// <summary>
        /// Field 1: Canonical resource name.<br/>
        /// Format: `namespaces/{namespace}/knowledge-bases/{knowledge_base}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Field 3: Human-readable display name for UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Field 6: Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The knowledge base tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The knowledge base type (persistent or ephemeral).<br/>
        /// Default is PERSISTENT if not specified during creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.KnowledgeBaseTypeJsonConverter))]
        public global::Instill.KnowledgeBaseType? Type { get; set; }

        /// <summary>
        /// The resource name of the system configuration.<br/>
        /// Format: `systems/{system}`<br/>
        /// Available systems: "systems/openai", "systems/gemini", or custom systems.<br/>
        /// If not specified, defaults to the default system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// The embedding configuration for the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddingConfig")]
        public global::Instill.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// The resource name of the active Milvus collection for this knowledge base.<br/>
        /// Format:<br/>
        /// `namespaces/{namespace}/knowledge-bases/{knowledge_base}/collections/{collection}`<br/>
        /// This supports collection versioning for embedding dimension changes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeCollection")]
        public string? ActiveCollection { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Knowledge base owner (User or Organization).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Instill.Owner? Owner { get; set; }

        /// <summary>
        /// Full resource name of the user who created this knowledge base.<br/>
        /// Format: `users/{user}`<br/>
        /// Optional for system-created knowledge bases (e.g., instill-agent).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// The user who created this knowledge base.<br/>
        /// Populated when creator_name is present.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Instill.V1betaUser? Creator { get; set; }

        /// <summary>
        /// The total files in knowledge base.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFiles")]
        public long? TotalFiles { get; set; }

        /// <summary>
        /// The total tokens in knowledge base.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// The current used storage in knowledge base.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedStorage")]
        public string? UsedStorage { get; set; }

        /// <summary>
        /// The downstream apps.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreamApps")]
        public global::System.Collections.Generic.IList<string>? DownstreamApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="name">
        /// Field 1: Canonical resource name.<br/>
        /// Format: `namespaces/{namespace}/knowledge-bases/{knowledge_base}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="slug"></param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="createTime">
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// The knowledge base tags.
        /// </param>
        /// <param name="type">
        /// The knowledge base type (persistent or ephemeral).<br/>
        /// Default is PERSISTENT if not specified during creation.
        /// </param>
        /// <param name="system">
        /// The resource name of the system configuration.<br/>
        /// Format: `systems/{system}`<br/>
        /// Available systems: "systems/openai", "systems/gemini", or custom systems.<br/>
        /// If not specified, defaults to the default system.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the knowledge base.
        /// </param>
        /// <param name="activeCollection">
        /// The resource name of the active Milvus collection for this knowledge base.<br/>
        /// Format:<br/>
        /// `namespaces/{namespace}/knowledge-bases/{knowledge_base}/collections/{collection}`<br/>
        /// This supports collection versioning for embedding dimension changes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownerName">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Knowledge base owner (User or Organization).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorName">
        /// Full resource name of the user who created this knowledge base.<br/>
        /// Format: `users/{user}`<br/>
        /// Optional for system-created knowledge bases (e.g., instill-agent).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// The user who created this knowledge base.<br/>
        /// Populated when creator_name is present.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalFiles">
        /// The total files in knowledge base.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalTokens">
        /// The total tokens in knowledge base.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usedStorage">
        /// The current used storage in knowledge base.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="downstreamApps">
        /// The downstream apps.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBase(
            string displayName,
            string? name,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.KnowledgeBaseType? type,
            string? system,
            global::Instill.EmbeddingConfig? embeddingConfig,
            string? activeCollection,
            string? ownerName,
            global::Instill.Owner? owner,
            string? creatorName,
            global::Instill.V1betaUser? creator,
            long? totalFiles,
            long? totalTokens,
            string? usedStorage,
            global::System.Collections.Generic.IList<string>? downstreamApps)
        {
            this.Name = name;
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Tags = tags;
            this.Type = type;
            this.System = system;
            this.EmbeddingConfig = embeddingConfig;
            this.ActiveCollection = activeCollection;
            this.OwnerName = ownerName;
            this.Owner = owner;
            this.CreatorName = creatorName;
            this.Creator = creator;
            this.TotalFiles = totalFiles;
            this.TotalTokens = totalTokens;
            this.UsedStorage = usedStorage;
            this.DownstreamApps = downstreamApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        public KnowledgeBase()
        {
        }
    }
}