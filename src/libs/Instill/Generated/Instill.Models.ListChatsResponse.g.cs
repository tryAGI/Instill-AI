
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListChatsResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chats")]
        public global::System.Collections.Generic.IList<global::Instill.Chat>? Chats { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="ListChatsResponse" /> class.
        /// </summary>
        /// <param name="chats">
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListChatsResponse(
            global::System.Collections.Generic.IList<global::Instill.Chat>? chats,
            string? nextPageToken,
            int? totalSize)
        {
            this.Chats = chats;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatsResponse" /> class.
        /// </summary>
        public ListChatsResponse()
        {
        }
    }
}