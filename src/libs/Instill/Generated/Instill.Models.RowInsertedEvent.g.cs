
#nullable enable

namespace Instill
{
    /// <summary>
    /// RowInsertedEvent represents an event for a row being inserted.
    /// </summary>
    public sealed partial class RowInsertedEvent
    {
        /// <summary>
        /// The row that was inserted.<br/>
        /// Note: Only the row metadata is returned, not the cell data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public global::Instill.Row? Row { get; set; }

        /// <summary>
        /// The unique identifier of the row that was inserted before.<br/>
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
        /// Initializes a new instance of the <see cref="RowInsertedEvent" /> class.
        /// </summary>
        /// <param name="row">
        /// The row that was inserted.<br/>
        /// Note: Only the row metadata is returned, not the cell data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="beforeRowUid">
        /// The unique identifier of the row that was inserted before.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RowInsertedEvent(
            global::Instill.Row? row,
            string? beforeRowUid)
        {
            this.Row = row;
            this.BeforeRowUid = beforeRowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowInsertedEvent" /> class.
        /// </summary>
        public RowInsertedEvent()
        {
        }
    }
}