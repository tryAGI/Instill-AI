
#nullable enable

namespace Instill
{
    /// <summary>
    /// RowDeletedEvent represents an event for a row being deleted.
    /// </summary>
    public sealed partial class RowDeletedEvent
    {
        /// <summary>
        /// The unique identifier of the row that was deleted.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowUid")]
        public string? RowUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RowDeletedEvent" /> class.
        /// </summary>
        /// <param name="rowUid">
        /// The unique identifier of the row that was deleted.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RowDeletedEvent(
            string? rowUid)
        {
            this.RowUid = rowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowDeletedEvent" /> class.
        /// </summary>
        public RowDeletedEvent()
        {
        }
    }
}