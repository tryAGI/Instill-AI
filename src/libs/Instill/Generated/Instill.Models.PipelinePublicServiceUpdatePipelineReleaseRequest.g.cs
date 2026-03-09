
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinePublicServiceUpdatePipelineReleaseRequest
    {
        /// <summary>
        /// Field 2: Release resource ID (used in `name` as the last segment). It must<br/>
        /// be a sematic version vX.Y.Z.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Field 3: Human-readable display name for UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Field 4: URL-friendly slug (alias for the release).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Field 6: Release description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Recipe of the versioned pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipe")]
        public object? Recipe { get; set; }

        /// <summary>
        /// Pipeline creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Pipeline update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Pipeline deletion time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// README.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecification")]
        public global::Instill.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawRecipe")]
        public string? RawRecipe { get; set; }

        /// <summary>
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::Instill.Endpoints? Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdatePipelineReleaseRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Field 2: Release resource ID (used in `name` as the last segment). It must<br/>
        /// be a sematic version vX.Y.Z.
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (alias for the release).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 6: Release description.
        /// </param>
        /// <param name="recipe">
        /// Recipe of the versioned pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Pipeline creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Pipeline update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Pipeline deletion time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </param>
        /// <param name="readme">
        /// README.
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="endpoints">
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinePublicServiceUpdatePipelineReleaseRequest(
            string? id,
            string? displayName,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            object? recipe,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            object? metadata,
            string? readme,
            global::Instill.DataSpecification? dataSpecification,
            string? rawRecipe,
            global::Instill.Endpoints? endpoints)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.Recipe = recipe;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.Metadata = metadata;
            this.Readme = readme;
            this.DataSpecification = dataSpecification;
            this.RawRecipe = rawRecipe;
            this.Endpoints = endpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdatePipelineReleaseRequest" /> class.
        /// </summary>
        public PipelinePublicServiceUpdatePipelineReleaseRequest()
        {
        }
    }
}