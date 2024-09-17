
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Instill
{
    /// <summary>
    /// DeleteCatalogResponse represents a response for deleting a catalog.
    /// </summary>
    public sealed partial class DeleteCatalogResponse
    {
        /// <summary>
        /// The catalog identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AllOfJsonConverterFactory1))]
        public global::Instill.AllOf<global::Instill.Catalog>? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}