
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListTablesResponse contains the list of tables.
    /// </summary>
    public sealed partial class ListTablesResponse
    {
        /// <summary>
        /// The list of tables.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Instill.Table>? Tables { get; set; }

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
        /// Initializes a new instance of the <see cref="ListTablesResponse" /> class.
        /// </summary>
        /// <param name="tables">
        /// The list of tables.<br/>
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListTablesResponse(
            global::System.Collections.Generic.IList<global::Instill.Table>? tables,
            string? nextPageToken,
            int? totalSize)
        {
            this.Tables = tables;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTablesResponse" /> class.
        /// </summary>
        public ListTablesResponse()
        {
        }
    }
}