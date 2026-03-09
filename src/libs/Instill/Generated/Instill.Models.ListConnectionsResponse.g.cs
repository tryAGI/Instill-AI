
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListConnectionsResponse contains a paginated list of connections.
    /// </summary>
    public sealed partial class ListConnectionsResponse
    {
        /// <summary>
        /// A list of connections matching the request parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.IList<global::Instill.PipelineV1betaConnection>? Connections { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of items.<br/>
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
        /// Initializes a new instance of the <see cref="ListConnectionsResponse" /> class.
        /// </summary>
        /// <param name="connections">
        /// A list of connections matching the request parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of items.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListConnectionsResponse(
            global::System.Collections.Generic.IList<global::Instill.PipelineV1betaConnection>? connections,
            string? nextPageToken,
            int? totalSize)
        {
            this.Connections = connections;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectionsResponse" /> class.
        /// </summary>
        public ListConnectionsResponse()
        {
        }
    }
}