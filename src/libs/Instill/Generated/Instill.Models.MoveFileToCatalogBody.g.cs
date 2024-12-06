
#nullable enable

namespace Instill
{
    /// <summary>
    /// MoveFileToCatalogRequest represents a request to move a file to another catalog.
    /// </summary>
    public sealed partial class MoveFileToCatalogBody
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileUid { get; set; }

        /// <summary>
        /// The target catalog id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toCatalogId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToCatalogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileToCatalogBody" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// The file uid.
        /// </param>
        /// <param name="toCatalogId">
        /// The target catalog id.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MoveFileToCatalogBody(
            string fileUid,
            string toCatalogId)
        {
            this.FileUid = fileUid ?? throw new global::System.ArgumentNullException(nameof(fileUid));
            this.ToCatalogId = toCatalogId ?? throw new global::System.ArgumentNullException(nameof(toCatalogId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileToCatalogBody" /> class.
        /// </summary>
        public MoveFileToCatalogBody()
        {
        }
    }
}