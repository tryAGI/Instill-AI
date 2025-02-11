
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListChatTablesResponse contains the list of tables bound to a chat.
    /// </summary>
    public sealed partial class ListChatTablesResponse
    {
        /// <summary>
        /// The tables bound to the chat.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Instill.Table>? Tables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTablesResponse" /> class.
        /// </summary>
        /// <param name="tables">
        /// The tables bound to the chat.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListChatTablesResponse(
            global::System.Collections.Generic.IList<global::Instill.Table>? tables)
        {
            this.Tables = tables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTablesResponse" /> class.
        /// </summary>
        public ListChatTablesResponse()
        {
        }
    }
}