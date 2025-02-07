
#nullable enable

namespace Instill
{
    /// <summary>
    /// Owner is a wrapper for User and Organization, used to embed owner information in other resources.
    /// </summary>
    public sealed partial class Owner
    {
        /// <summary>
        /// User.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Instill.User? User { get; set; }

        /// <summary>
        /// Organization.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Instill.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Owner" /> class.
        /// </summary>
        /// <param name="user">
        /// User.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Organization.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Owner(
            global::Instill.User? user,
            global::Instill.Organization? organization)
        {
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Owner" /> class.
        /// </summary>
        public Owner()
        {
        }
    }
}