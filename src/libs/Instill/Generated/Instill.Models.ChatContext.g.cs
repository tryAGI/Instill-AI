
#nullable enable

namespace Instill
{
    /// <summary>
    /// The context for the message.
    /// </summary>
    public sealed partial class ChatContext
    {
        /// <summary>
        /// The table uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUids")]
        public global::System.Collections.Generic.IList<string>? TableUids { get; set; }

        /// <summary>
        /// The folder uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderUids")]
        public global::System.Collections.Generic.IList<string>? FolderUids { get; set; }

        /// <summary>
        /// The catalog uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUids")]
        public global::System.Collections.Generic.IList<string>? CatalogUids { get; set; }

        /// <summary>
        /// The file uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// The folders to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        public global::System.Collections.Generic.IList<global::Instill.ChatContextFolder>? Folders { get; set; }

        /// <summary>
        /// The catalogs to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogs")]
        public global::System.Collections.Generic.IList<global::Instill.ChatContextCatalog>? Catalogs { get; set; }

        /// <summary>
        /// The tables to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Instill.ChatContextTable>? Tables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContext" /> class.
        /// </summary>
        /// <param name="tableUids">
        /// The table uids to include in the context.
        /// </param>
        /// <param name="folderUids">
        /// The folder uids to include in the context.
        /// </param>
        /// <param name="catalogUids">
        /// The catalog uids to include in the context.
        /// </param>
        /// <param name="fileUids">
        /// The file uids to include in the context.
        /// </param>
        /// <param name="folders">
        /// The folders to include in the context.
        /// </param>
        /// <param name="catalogs">
        /// The catalogs to include in the context.
        /// </param>
        /// <param name="tables">
        /// The tables to include in the context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContext(
            global::System.Collections.Generic.IList<string>? tableUids,
            global::System.Collections.Generic.IList<string>? folderUids,
            global::System.Collections.Generic.IList<string>? catalogUids,
            global::System.Collections.Generic.IList<string>? fileUids,
            global::System.Collections.Generic.IList<global::Instill.ChatContextFolder>? folders,
            global::System.Collections.Generic.IList<global::Instill.ChatContextCatalog>? catalogs,
            global::System.Collections.Generic.IList<global::Instill.ChatContextTable>? tables)
        {
            this.TableUids = tableUids;
            this.FolderUids = folderUids;
            this.CatalogUids = catalogUids;
            this.FileUids = fileUids;
            this.Folders = folders;
            this.Catalogs = catalogs;
            this.Tables = tables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContext" /> class.
        /// </summary>
        public ChatContext()
        {
        }
    }
}