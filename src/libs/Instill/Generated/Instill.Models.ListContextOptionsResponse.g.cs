
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListContextOptionsResponse represents a response to a request to list context options.
    /// </summary>
    public sealed partial class ListContextOptionsResponse
    {
        /// <summary>
        /// The folder options.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderOptions")]
        public global::System.Collections.Generic.IList<global::Instill.FolderOption>? FolderOptions { get; set; }

        /// <summary>
        /// The table options.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableOptions")]
        public global::System.Collections.Generic.IList<global::Instill.TableOption>? TableOptions { get; set; }

        /// <summary>
        /// The catalog options.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogOptions")]
        public global::System.Collections.Generic.IList<global::Instill.CatalogOption>? CatalogOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContextOptionsResponse" /> class.
        /// </summary>
        /// <param name="folderOptions">
        /// The folder options.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tableOptions">
        /// The table options.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogOptions">
        /// The catalog options.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListContextOptionsResponse(
            global::System.Collections.Generic.IList<global::Instill.FolderOption>? folderOptions,
            global::System.Collections.Generic.IList<global::Instill.TableOption>? tableOptions,
            global::System.Collections.Generic.IList<global::Instill.CatalogOption>? catalogOptions)
        {
            this.FolderOptions = folderOptions;
            this.TableOptions = tableOptions;
            this.CatalogOptions = catalogOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListContextOptionsResponse" /> class.
        /// </summary>
        public ListContextOptionsResponse()
        {
        }
    }
}