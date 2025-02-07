
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListRowsResponse contains the requested rows.
    /// </summary>
    public sealed partial class ListRowsResponse
    {
        /// <summary>
        /// The list of rows.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::Instill.Row>? Rows { get; set; }

        /// <summary>
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The total number of rows that match the request.<br/>
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
        /// Initializes a new instance of the <see cref="ListRowsResponse" /> class.
        /// </summary>
        /// <param name="rows">
        /// The list of rows.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of rows that match the request.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRowsResponse(
            global::System.Collections.Generic.IList<global::Instill.Row>? rows,
            string? nextPageToken,
            int? totalSize)
        {
            this.Rows = rows;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRowsResponse" /> class.
        /// </summary>
        public ListRowsResponse()
        {
        }
    }
}