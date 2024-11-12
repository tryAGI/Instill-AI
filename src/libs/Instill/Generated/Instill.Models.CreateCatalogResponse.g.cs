
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateCatalogResponse represents a response for creating a catalog.
    /// </summary>
    public sealed partial class CreateCatalogResponse
    {
        /// <summary>
        /// The created catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Catalog Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// The created catalog.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateCatalogResponse(
            global::Instill.Catalog catalog)
        {
            this.Catalog = catalog ?? throw new global::System.ArgumentNullException(nameof(catalog));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogResponse" /> class.
        /// </summary>
        public CreateCatalogResponse()
        {
        }
    }
}