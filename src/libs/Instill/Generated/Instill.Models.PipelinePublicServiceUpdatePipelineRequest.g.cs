
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinePublicServiceUpdatePipelineRequest
    {
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
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// If omitted, server generates from display_name.<br/>
        /// Slug is NOT part of resource identity.
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
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Recipe { get; set; }

        /// <summary>
        /// Recipe in YAML format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawRecipe")]
        public string? RawRecipe { get; set; }

        /// <summary>
        /// Pipeline visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.PipelineVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.PipelineVisibility Visibility { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::Instill.Sharing? Sharing { get; set; }

        /// <summary>
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::Instill.PipelineV1betaPermission? Permission { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecification")]
        public global::Instill.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Instill.PipelineStats? Stats { get; set; }

        /// <summary>
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// README holds the pipeline documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Releases holds the history of pipeline versions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::System.Collections.Generic.IList<global::Instill.PipelineRelease>? Releases { get; set; }

        /// <summary>
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::Instill.Endpoints? Endpoints { get; set; }

        /// <summary>
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the pipeline is distributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Pipeline profile image in base64 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileImage")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Resource name of the owner namespace.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// Pipeline owner (User or Organization).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Instill.Owner? Owner { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// The user who created this pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Instill.V1betaUser? Creator { get; set; }

        /// <summary>
        /// Soft delete timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdatePipelineRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="recipe">
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </param>
        /// <param name="visibility">
        /// Pipeline visibility.
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// If omitted, server generates from display_name.<br/>
        /// Slug is NOT part of resource identity.
        /// </param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
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
        /// <param name="rawRecipe">
        /// Recipe in YAML format.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="permission">
        /// Permission defines how a pipeline can be used.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="stats">
        /// Statistic data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </param>
        /// <param name="readme">
        /// README holds the pipeline documentation.
        /// </param>
        /// <param name="releases">
        /// Releases holds the history of pipeline versions.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endpoints">
        /// Pipeline endpoints.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the pipeline is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Pipeline profile image in base64 format.
        /// </param>
        /// <param name="ownerName">
        /// Resource name of the owner namespace.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Pipeline owner (User or Organization).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorName">
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// The user who created this pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Soft delete timestamp.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinePublicServiceUpdatePipelineRequest(
            string displayName,
            object recipe,
            global::Instill.PipelineVisibility visibility,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? rawRecipe,
            global::Instill.Sharing? sharing,
            global::Instill.PipelineV1betaPermission? permission,
            global::Instill.DataSpecification? dataSpecification,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.PipelineStats? stats,
            object? metadata,
            string? readme,
            global::System.Collections.Generic.IList<global::Instill.PipelineRelease>? releases,
            global::Instill.Endpoints? endpoints,
            string? sourceUrl,
            string? documentationUrl,
            string? license,
            string? profileImage,
            string? ownerName,
            global::Instill.Owner? owner,
            string? creatorName,
            global::Instill.V1betaUser? creator,
            global::System.DateTime? deleteTime)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Recipe = recipe ?? throw new global::System.ArgumentNullException(nameof(recipe));
            this.RawRecipe = rawRecipe;
            this.Visibility = visibility;
            this.Sharing = sharing;
            this.Permission = permission;
            this.DataSpecification = dataSpecification;
            this.Tags = tags;
            this.Stats = stats;
            this.Metadata = metadata;
            this.Readme = readme;
            this.Releases = releases;
            this.Endpoints = endpoints;
            this.SourceUrl = sourceUrl;
            this.DocumentationUrl = documentationUrl;
            this.License = license;
            this.ProfileImage = profileImage;
            this.OwnerName = ownerName;
            this.Owner = owner;
            this.CreatorName = creatorName;
            this.Creator = creator;
            this.DeleteTime = deleteTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdatePipelineRequest" /> class.
        /// </summary>
        public PipelinePublicServiceUpdatePipelineRequest()
        {
        }
    }
}