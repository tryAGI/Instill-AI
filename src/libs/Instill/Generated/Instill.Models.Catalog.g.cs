
#nullable enable

namespace Instill
{
    /// <summary>
    /// Catalog represents a catalog.
    /// </summary>
    public sealed partial class Catalog
    {
        /// <summary>
        /// The catalog uid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// The catalog id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// The catalog name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The creation time of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// The last update time of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// The owner/namespace of the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The catalog converting pipelines.<br/>
        /// Deprecated: Conversion is now handled by AI providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertingPipelines")]
        public global::System.Collections.Generic.IList<string>? ConvertingPipelines { get; set; }

        /// <summary>
        /// The catalog splitting pipelines.<br/>
        /// Deprecated: Chunking is now handled internally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splittingPipelines")]
        public global::System.Collections.Generic.IList<string>? SplittingPipelines { get; set; }

        /// <summary>
        /// The catalog embedding pipelines.<br/>
        /// Deprecated: Use embedding_config instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddingPipelines")]
        public global::System.Collections.Generic.IList<string>? EmbeddingPipelines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreamApps")]
        public global::System.Collections.Generic.IList<string>? DownstreamApps { get; set; }

        /// <summary>
        /// The total files in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFiles")]
        public long? TotalFiles { get; set; }

        /// <summary>
        /// The total tokens in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// The current used storage in catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedStorage")]
        public string? UsedStorage { get; set; }

        /// <summary>
        /// The catalog summarizing pipelines.<br/>
        /// Deprecated: Summarization is now handled by AI providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarizingPipelines")]
        public global::System.Collections.Generic.IList<string>? SummarizingPipelines { get; set; }

        /// <summary>
        /// The embedding configuration for the catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddingConfig")]
        public global::Instill.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog" /> class.
        /// </summary>
        /// <param name="catalogUid">
        /// The catalog uid.
        /// </param>
        /// <param name="catalogId">
        /// The catalog id.
        /// </param>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="createTime">
        /// The creation time of the catalog.
        /// </param>
        /// <param name="updateTime">
        /// The last update time of the catalog.
        /// </param>
        /// <param name="ownerName">
        /// The owner/namespace of the catalog.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="convertingPipelines">
        /// The catalog converting pipelines.<br/>
        /// Deprecated: Conversion is now handled by AI providers.
        /// </param>
        /// <param name="splittingPipelines">
        /// The catalog splitting pipelines.<br/>
        /// Deprecated: Chunking is now handled internally.
        /// </param>
        /// <param name="embeddingPipelines">
        /// The catalog embedding pipelines.<br/>
        /// Deprecated: Use embedding_config instead.
        /// </param>
        /// <param name="downstreamApps"></param>
        /// <param name="totalFiles">
        /// The total files in catalog.
        /// </param>
        /// <param name="totalTokens">
        /// The total tokens in catalog.
        /// </param>
        /// <param name="usedStorage">
        /// The current used storage in catalog.
        /// </param>
        /// <param name="summarizingPipelines">
        /// The catalog summarizing pipelines.<br/>
        /// Deprecated: Summarization is now handled by AI providers.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the catalog.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Catalog(
            string? catalogUid,
            string? catalogId,
            string? name,
            string? description,
            string? createTime,
            string? updateTime,
            string? ownerName,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? convertingPipelines,
            global::System.Collections.Generic.IList<string>? splittingPipelines,
            global::System.Collections.Generic.IList<string>? embeddingPipelines,
            global::System.Collections.Generic.IList<string>? downstreamApps,
            long? totalFiles,
            long? totalTokens,
            string? usedStorage,
            global::System.Collections.Generic.IList<string>? summarizingPipelines,
            global::Instill.EmbeddingConfig? embeddingConfig)
        {
            this.CatalogUid = catalogUid;
            this.CatalogId = catalogId;
            this.Name = name;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.OwnerName = ownerName;
            this.Tags = tags;
            this.ConvertingPipelines = convertingPipelines;
            this.SplittingPipelines = splittingPipelines;
            this.EmbeddingPipelines = embeddingPipelines;
            this.DownstreamApps = downstreamApps;
            this.TotalFiles = totalFiles;
            this.TotalTokens = totalTokens;
            this.UsedStorage = usedStorage;
            this.SummarizingPipelines = summarizingPipelines;
            this.EmbeddingConfig = embeddingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog" /> class.
        /// </summary>
        public Catalog()
        {
        }
    }
}