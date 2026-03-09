
#nullable enable

namespace Instill
{
    /// <summary>
    /// User describes an individual that interacts with Instill AI. It doesn't<br/>
    /// contain any private information about the user.<br/>
    /// AIP Standard Field Ordering:<br/>
    /// - name (field 1): Canonical resource name<br/>
    /// - id (field 2): Immutable canonical resource ID<br/>
    /// - display_name (field 3): Human-readable display name<br/>
    /// - slug (field 4): URL-friendly slug<br/>
    /// - aliases (field 5): Previous slugs for backward compatibility<br/>
    /// - description (field 6): Optional description<br/>
    /// - create_time (field 7): Creation timestamp<br/>
    /// - update_time (field 8): Update timestamp
    /// </summary>
    public sealed partial class V1betaUser
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
        /// Profile containing additional user information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public global::Instill.UserProfile? Profile { get; set; }

        /// <summary>
        /// Email.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1betaUser" /> class.
        /// </summary>
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
        /// <param name="profile">
        /// Profile containing additional user information.
        /// </param>
        /// <param name="email">
        /// Email.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1betaUser(
            string? name,
            string? id,
            string? displayName,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::Instill.UserProfile? profile,
            string? email)
        {
            this.Name = name;
            this.Id = id;
            this.DisplayName = displayName;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Profile = profile;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1betaUser" /> class.
        /// </summary>
        public V1betaUser()
        {
        }
    }
}