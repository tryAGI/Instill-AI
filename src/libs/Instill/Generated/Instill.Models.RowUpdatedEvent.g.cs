
#nullable enable

namespace Instill
{
    /// <summary>
    /// RowUpdatedEvent represents an event for a row being updated.
    /// </summary>
    public sealed partial class RowUpdatedEvent
    {
        /// <summary>
        /// The row that was updated.<br/>
        /// Note: Only the row metadata is returned, not the cell data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public global::Instill.Row? Row { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RowUpdatedEvent" /> class.
        /// </summary>
        /// <param name="row">
        /// The row that was updated.<br/>
        /// Note: Only the row metadata is returned, not the cell data.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RowUpdatedEvent(
            global::Instill.Row? row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowUpdatedEvent" /> class.
        /// </summary>
        public RowUpdatedEvent()
        {
        }
    }
}