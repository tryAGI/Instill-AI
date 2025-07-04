
#nullable enable

namespace Instill
{
    /// <summary>
    /// Represents a catalog.
    /// </summary>
    public sealed partial class ChatContextCatalog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContextCatalog" /> class.
        /// </summary>
        /// <param name="catalogUid"></param>
        /// <param name="fileUids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContextCatalog(
            string catalogUid,
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.CatalogUid = catalogUid ?? throw new global::System.ArgumentNullException(nameof(catalogUid));
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContextCatalog" /> class.
        /// </summary>
        public ChatContextCatalog()
        {
        }
    }
}