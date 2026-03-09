
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListFilesResponse represents a response for listing files.
    /// </summary>
    public sealed partial class ListFilesResponse
    {
        /// <summary>
        /// The list of files.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Instill.File>? Files { get; set; }

        /// <summary>
        /// The total number of files.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The list of files.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of files.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListFilesResponse(
            global::System.Collections.Generic.IList<global::Instill.File>? files,
            int? totalSize,
            int? pageSize,
            string? nextPageToken)
        {
            this.Files = files;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFilesResponse" /> class.
        /// </summary>
        public ListFilesResponse()
        {
        }
    }
}