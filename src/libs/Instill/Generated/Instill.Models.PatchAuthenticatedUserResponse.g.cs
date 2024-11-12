
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthenticatedUserResponse
    {
        /// <summary>
        /// The updated user resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Instill.AuthenticatedUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="user">
        /// The updated user resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PatchAuthenticatedUserResponse(
            global::Instill.AuthenticatedUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthenticatedUserResponse" /> class.
        /// </summary>
        public PatchAuthenticatedUserResponse()
        {
        }
    }
}