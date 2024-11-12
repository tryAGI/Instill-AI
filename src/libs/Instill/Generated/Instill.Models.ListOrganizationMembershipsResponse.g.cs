
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListOrganizationMembershipsResponse contains a list of memberships.
    /// </summary>
    public sealed partial class ListOrganizationMembershipsResponse
    {
        /// <summary>
        /// The organization memberships, i.e., the users that belong to the<br/>
        /// organization.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        public global::System.Collections.Generic.IList<global::Instill.OrganizationMembership>? Memberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationMembershipsResponse" /> class.
        /// </summary>
        /// <param name="memberships">
        /// The organization memberships, i.e., the users that belong to the<br/>
        /// organization.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListOrganizationMembershipsResponse(
            global::System.Collections.Generic.IList<global::Instill.OrganizationMembership>? memberships)
        {
            this.Memberships = memberships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationMembershipsResponse" /> class.
        /// </summary>
        public ListOrganizationMembershipsResponse()
        {
        }
    }
}