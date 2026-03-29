
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Field 1: Canonical resource name.<br/>
        /// Format: `namespaces/{namespace}/models/{model}`.<br/>
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
        /// The model definition that has been used to import the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDefinition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelDefinition { get; set; }

        /// <summary>
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Configuration { get; set; }

        /// <summary>
        /// Model task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.TaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Task Task { get; set; }

        /// <summary>
        /// Model visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ModelVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.ModelVisibility Visibility { get; set; }

        /// <summary>
        /// Permission defines how the model can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::Instill.V1alphaPermission? Permission { get; set; }

        /// <summary>
        /// Region of choice for the particular provider to host the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Hardware of choice to serve the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// Input schema for the model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Output schema for the model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Version names.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<string>? Versions { get; set; }

        /// <summary>
        /// Statistic data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Instill.ModelStats? Stats { get; set; }

        /// <summary>
        /// README holds the model documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceUrl")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A link to any extra information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// License under which the model is distributed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Model profile image in base64 format.
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
        /// Model owner (User or Organization).<br/>
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
        /// The user who created this model.<br/>
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
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="modelDefinition">
        /// The model definition that has been used to import the model.
        /// </param>
        /// <param name="configuration">
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition.
        /// </param>
        /// <param name="task">
        /// Model task.
        /// </param>
        /// <param name="visibility">
        /// Model visibility.
        /// </param>
        /// <param name="region">
        /// Region of choice for the particular provider to host the model.
        /// </param>
        /// <param name="hardware">
        /// Hardware of choice to serve the model.
        /// </param>
        /// <param name="name">
        /// Field 1: Canonical resource name.<br/>
        /// Format: `namespaces/{namespace}/models/{model}`.<br/>
        /// Included only in responses
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
        /// <param name="permission">
        /// Permission defines how the model can be used.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputSchema">
        /// Input schema for the model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputSchema">
        /// Output schema for the model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="versions">
        /// Version names.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="stats">
        /// Statistic data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="readme">
        /// README holds the model documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the model is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Model profile image in base64 format.
        /// </param>
        /// <param name="ownerName">
        /// Resource name of the owner namespace.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Model owner (User or Organization).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorName">
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// The user who created this model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Soft delete timestamp.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string displayName,
            string modelDefinition,
            object configuration,
            global::Instill.Task task,
            global::Instill.ModelVisibility visibility,
            string region,
            string hardware,
            string? name,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::Instill.V1alphaPermission? permission,
            object? inputSchema,
            object? outputSchema,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? versions,
            global::Instill.ModelStats? stats,
            string? readme,
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
            this.Name = name;
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.ModelDefinition = modelDefinition ?? throw new global::System.ArgumentNullException(nameof(modelDefinition));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Task = task;
            this.Visibility = visibility;
            this.Permission = permission;
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
            this.Tags = tags;
            this.Versions = versions;
            this.Stats = stats;
            this.Readme = readme;
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
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}