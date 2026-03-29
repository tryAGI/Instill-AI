
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinePublicServiceUpdateNamespaceSecretRequest
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored here.<br/>
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
        /// Field 9: The value of the secret, which is input-only and will never be returned in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdateNamespaceSecretRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="slug"></param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored here.<br/>
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
        /// <param name="value">
        /// Field 9: The value of the secret, which is input-only and will never be returned in API responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinePublicServiceUpdateNamespaceSecretRequest(
            string displayName,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? value)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinePublicServiceUpdateNamespaceSecretRequest" /> class.
        /// </summary>
        public PipelinePublicServiceUpdateNamespaceSecretRequest()
        {
        }
    }
}