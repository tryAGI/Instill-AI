
#nullable enable

namespace Instill
{
    /// <summary>
    /// UserProfile describes the public data of a user.
    /// </summary>
    public sealed partial class UserProfile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Biography.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Avatar in base64 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Public email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicEmail")]
        public string? PublicEmail { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialProfileLinks")]
        public global::System.Collections.Generic.Dictionary<string, string>? SocialProfileLinks { get; set; }

        /// <summary>
        /// Full legal name. Used for formal communications.<br/>
        /// Example: "John Doe" - this is also used to auto-generate the user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="bio">
        /// Biography.
        /// </param>
        /// <param name="avatar">
        /// Avatar in base64 format.
        /// </param>
        /// <param name="publicEmail">
        /// Public email.
        /// </param>
        /// <param name="companyName">
        /// Company name.
        /// </param>
        /// <param name="socialProfileLinks">
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </param>
        /// <param name="fullName">
        /// Full legal name. Used for formal communications.<br/>
        /// Example: "John Doe" - this is also used to auto-generate the user ID.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfile(
            string displayName,
            string? bio,
            string? avatar,
            string? publicEmail,
            string? companyName,
            global::System.Collections.Generic.Dictionary<string, string>? socialProfileLinks,
            string? fullName,
            object? metadata)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Bio = bio;
            this.Avatar = avatar;
            this.PublicEmail = publicEmail;
            this.CompanyName = companyName;
            this.SocialProfileLinks = socialProfileLinks;
            this.FullName = fullName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        public UserProfile()
        {
        }
    }
}