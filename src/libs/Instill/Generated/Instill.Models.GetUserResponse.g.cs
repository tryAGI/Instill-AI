
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Instill
{
    /// <summary>
    /// GetUserResponse contains the requested user.
    /// </summary>
    public sealed partial class GetUserResponse
    {
        /// <summary>
        /// The user resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AllOfJsonConverterFactory1))]
        public global::Instill.AllOf<global::Instill.User9>? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}