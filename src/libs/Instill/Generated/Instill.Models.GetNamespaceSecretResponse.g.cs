
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetNamespaceSecretResponse contains the requested secret.
    /// </summary>
    public sealed partial class GetNamespaceSecretResponse
    {
        /// <summary>
        /// The secret resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::Instill.Secret? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The secret resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetNamespaceSecretResponse(
            global::Instill.Secret? secret)
        {
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespaceSecretResponse" /> class.
        /// </summary>
        public GetNamespaceSecretResponse()
        {
        }
    }
}