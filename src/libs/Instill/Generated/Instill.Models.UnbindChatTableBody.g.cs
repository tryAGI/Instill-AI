
#nullable enable

namespace Instill
{
    /// <summary>
    /// UnbindChatTableRequest represents a request to unbind a table from a chat.
    /// </summary>
    public sealed partial class UnbindChatTableBody
    {
        /// <summary>
        /// The UID of the table to unbind from the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnbindChatTableBody" /> class.
        /// </summary>
        /// <param name="tableUid">
        /// The UID of the table to unbind from the chat.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnbindChatTableBody(
            string tableUid)
        {
            this.TableUid = tableUid ?? throw new global::System.ArgumentNullException(nameof(tableUid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnbindChatTableBody" /> class.
        /// </summary>
        public UnbindChatTableBody()
        {
        }
    }
}