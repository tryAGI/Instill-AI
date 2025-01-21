
#nullable enable

namespace Instill
{
    /// <summary>
    /// RowsMovedEvent represents an event for multiple rows being moved.
    /// </summary>
    public sealed partial class RowsMovedEvent
    {
        /// <summary>
        /// The unique identifiers of the rows that were moved.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowUids")]
        public global::System.Collections.Generic.IList<string>? RowUids { get; set; }

        /// <summary>
        /// The unique identifier of the row that was moved before.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeRowUid")]
        public string? BeforeRowUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RowsMovedEvent" /> class.
        /// </summary>
        /// <param name="rowUids">
        /// The unique identifiers of the rows that were moved.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="beforeRowUid">
        /// The unique identifier of the row that was moved before.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RowsMovedEvent(
            global::System.Collections.Generic.IList<string>? rowUids,
            string? beforeRowUid)
        {
            this.RowUids = rowUids;
            this.BeforeRowUid = beforeRowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowsMovedEvent" /> class.
        /// </summary>
        public RowsMovedEvent()
        {
        }
    }
}