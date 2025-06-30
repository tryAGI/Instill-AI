
#nullable enable

namespace Instill
{
    /// <summary>
    /// CatalogOption represents a catalog option.
    /// </summary>
    public sealed partial class CatalogOption
    {
        /// <summary>
        /// The UID of the catalog.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// The ID of the catalog.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// The catalog description.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The UIDs of the files in the catalog.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileOptions")]
        public global::System.Collections.Generic.IList<global::Instill.FileOption>? FileOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogOption" /> class.
        /// </summary>
        /// <param name="catalogUid">
        /// The UID of the catalog.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogId">
        /// The ID of the catalog.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// The catalog description.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileOptions">
        /// The UIDs of the files in the catalog.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CatalogOption(
            string? catalogUid,
            string? catalogId,
            string? description,
            global::System.Collections.Generic.IList<global::Instill.FileOption>? fileOptions)
        {
            this.CatalogUid = catalogUid;
            this.CatalogId = catalogId;
            this.Description = description;
            this.FileOptions = fileOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogOption" /> class.
        /// </summary>
        public CatalogOption()
        {
        }
    }
}