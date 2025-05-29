
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListFoldersResponse contains the list of folders.
    /// </summary>
    public sealed partial class ListFoldersResponse
    {
        /// <summary>
        /// The list of folders.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folders")]
        public global::System.Collections.Generic.IList<global::Instill.Folder>? Folders { get; set; }

        /// <summary>
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The total number of tables.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFoldersResponse" /> class.
        /// </summary>
        /// <param name="folders">
        /// The list of folders.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of tables.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFoldersResponse(
            global::System.Collections.Generic.IList<global::Instill.Folder>? folders,
            string? nextPageToken,
            int? totalSize)
        {
            this.Folders = folders;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFoldersResponse" /> class.
        /// </summary>
        public ListFoldersResponse()
        {
        }
    }
}