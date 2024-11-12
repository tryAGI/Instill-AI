
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateCatalogResponse represents a response for updating a catalog.
    /// </summary>
    public sealed partial class UpdateCatalogResponse
    {
        /// <summary>
        /// The updated catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        public global::Instill.Catalog? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// The updated catalog.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateCatalogResponse(
            global::Instill.Catalog? catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogResponse" /> class.
        /// </summary>
        public UpdateCatalogResponse()
        {
        }
    }
}