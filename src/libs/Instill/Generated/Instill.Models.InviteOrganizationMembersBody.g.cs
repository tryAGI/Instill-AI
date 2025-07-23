
#nullable enable

namespace Instill
{
    /// <summary>
    /// InviteOrganizationMembersRequest represents a request to invite members to an<br/>
    /// organization.
    /// </summary>
    public sealed partial class InviteOrganizationMembersBody
    {
        /// <summary>
        /// The members to invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteOrganizationMembersBody" /> class.
        /// </summary>
        /// <param name="emails">
        /// The members to invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteOrganizationMembersBody(
            global::System.Collections.Generic.IList<string> emails)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteOrganizationMembersBody" /> class.
        /// </summary>
        public InviteOrganizationMembersBody()
        {
        }
    }
}