
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateCatalogRequest represents a request to create a catalog.
    /// </summary>
    public sealed partial class CreateCatalogBody
    {
        /// <summary>
        /// The catalog name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.CatalogTypeJsonConverter))]
        public global::Instill.CatalogType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateCatalogBody(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.CatalogType? type)
        {
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogBody" /> class.
        /// </summary>
        public CreateCatalogBody()
        {
        }
    }
}