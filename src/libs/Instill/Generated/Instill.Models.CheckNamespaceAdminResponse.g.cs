
#nullable enable

namespace Instill
{
    /// <summary>
    /// CheckNamespaceAdminResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceAdminResponse
    {
        /// <summary>
        /// Namespace type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter))]
        public global::Instill.CheckNamespaceAdminResponseNamespace? Type { get; set; }

        /// <summary>
        /// Namespace UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Instill.User? User { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Instill.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}