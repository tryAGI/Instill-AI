
#nullable enable

namespace Instill
{
    /// <summary>
    /// AuthenticatedUser contains the information of an authenticated user, i.e.,<br/>
    /// the public user information plus some fields that should only be accessed by<br/>
    /// the user themselves.<br/>
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
    public sealed partial class AuthenticatedUser
    {
        /// <summary>
        /// Field 1: Canonical resource name.<br/>
        /// Format: `users/{user}`.<br/>
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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Field 4: URL-friendly slug (NO prefix).<br/>
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
        /// Email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newsletterSubscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NewsletterSubscription { get; set; }

        /// <summary>
        /// Console cookie token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cookieToken")]
        public string? CookieToken { get; set; }

        /// <summary>
        /// Onboarding Status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboardingStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.OnboardingStatusJsonConverter))]
        public global::Instill.OnboardingStatus? OnboardingStatus { get; set; }

        /// <summary>
        /// Profile.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public global::Instill.UserProfile? Profile { get; set; }

        /// <summary>
        /// Is eligible for organization trial.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEligibleForOrganizationTrial")]
        public bool? IsEligibleForOrganizationTrial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedUser" /> class.
        /// </summary>
        /// <param name="email">
        /// Email.
        /// </param>
        /// <param name="newsletterSubscription">
        /// This defines whether the user is subscribed to Instill AI's newsletter.
        /// </param>
        /// <param name="name">
        /// Field 1: Canonical resource name.<br/>
        /// Format: `users/{user}`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (NO prefix).<br/>
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
        /// <param name="role">
        /// Role.<br/>
        /// It must be one of the following allowed roles:<br/>
        /// - `manager`<br/>
        /// - `ai-researcher`<br/>
        /// - `ai-engineer`<br/>
        /// - `data-engineer`<br/>
        /// - `data-scientist`<br/>
        /// - `analytics-engineer`<br/>
        /// - `hobbyist`
        /// </param>
        /// <param name="cookieToken">
        /// Console cookie token.
        /// </param>
        /// <param name="onboardingStatus">
        /// Onboarding Status.
        /// </param>
        /// <param name="profile">
        /// Profile.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isEligibleForOrganizationTrial">
        /// Is eligible for organization trial.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticatedUser(
            string email,
            bool newsletterSubscription,
            string? name,
            string? id,
            string? displayName,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? role,
            string? cookieToken,
            global::Instill.OnboardingStatus? onboardingStatus,
            global::Instill.UserProfile? profile,
            bool? isEligibleForOrganizationTrial)
        {
            this.Name = name;
            this.Id = id;
            this.DisplayName = displayName;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.NewsletterSubscription = newsletterSubscription;
            this.CookieToken = cookieToken;
            this.OnboardingStatus = onboardingStatus;
            this.Profile = profile;
            this.IsEligibleForOrganizationTrial = isEligibleForOrganizationTrial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedUser" /> class.
        /// </summary>
        public AuthenticatedUser()
        {
        }
    }
}