
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListCellAutofillAgentMessagesResponse is a response to a request to list messages in a cell.
    /// </summary>
    public sealed partial class ListCellAutofillAgentMessagesResponse
    {
        /// <summary>
        /// The messages in the cell.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Instill.AgentV1alphaMessage>? Messages { get; set; }

        /// <summary>
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The total number of messages.<br/>
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
        /// Initializes a new instance of the <see cref="ListCellAutofillAgentMessagesResponse" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages in the cell.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// The token for the next page of results.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of messages.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCellAutofillAgentMessagesResponse(
            global::System.Collections.Generic.IList<global::Instill.AgentV1alphaMessage>? messages,
            string? nextPageToken,
            int? totalSize)
        {
            this.Messages = messages;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCellAutofillAgentMessagesResponse" /> class.
        /// </summary>
        public ListCellAutofillAgentMessagesResponse()
        {
        }
    }
}