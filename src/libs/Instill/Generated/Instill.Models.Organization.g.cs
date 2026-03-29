
#nullable enable

namespace Instill
{
    /// <summary>
    /// Organizations group several users. As entities, they can own resources such<br/>
    /// as pipelines or releases.<br/>
    /// Organization represents a group of users working together.<br/>
    /// AIP Standard Field Ordering:<br/>
    /// - name (field 1): Canonical resource name<br/>
    /// - id (field 2): Immutable canonical resource ID<br/>
    /// - display_name (field 3): Human-readable display name<br/>
    /// - slug (field 4): URL-friendly slug<br/>
    /// - aliases (field 5): Previous slugs for backward compatibility<br/>
    /// - description (field 6): Optional description<br/>
    /// - create_time (field 7): Creation timestamp<br/>
    /// - update_time (field 8): Update timestamp<br/>
    /// - owner (field 9): Owner reference (string, not embedded object)
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
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
        /// Field 3: Human-readable display name for UI.<br/>
        /// This is copied from profile.display_name for convenience.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// Derived from display_name, used for human-friendly URLs.<br/>
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
        /// Field 6: Optional description / bio.<br/>
        /// Included only in responses
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
        /// Field 8: Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Field 9: Owner reference (the user that owns the organization).<br/>
        /// Format: `users/{user}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// Profile containing additional organization information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.OrganizationProfile Profile { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::Instill.MgmtV1betaPermission? Permission { get; set; }

        /// <summary>
        /// The organization stats.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Instill.OrganizationStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="profile">
        /// Profile containing additional organization information.
        /// </param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.<br/>
        /// This is copied from profile.display_name for convenience.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// Derived from display_name, used for human-friendly URLs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description / bio.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Field 8: Update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Field 9: Owner reference (the user that owns the organization).<br/>
        /// Format: `users/{user}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="permission">
        /// Included only in responses
        /// </param>
        /// <param name="stats">
        /// The organization stats.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            global::Instill.OrganizationProfile profile,
            string? name,
            string? id,
            string? displayName,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? owner,
            global::Instill.MgmtV1betaPermission? permission,
            global::Instill.OrganizationStats? stats)
        {
            this.Name = name;
            this.Id = id;
            this.DisplayName = displayName;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Owner = owner;
            this.Profile = profile ?? throw new global::System.ArgumentNullException(nameof(profile));
            this.Permission = permission;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}