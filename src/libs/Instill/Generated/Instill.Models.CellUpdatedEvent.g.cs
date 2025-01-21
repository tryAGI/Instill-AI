
#nullable enable

namespace Instill
{
    /// <summary>
    /// CellUpdatedEvent represents an event for a cell being updated.
    /// </summary>
    public sealed partial class CellUpdatedEvent
    {
        /// <summary>
        /// The cell that was updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell")]
        public global::Instill.Cell? Cell { get; set; }

        /// <summary>
        /// Whether the event is a delta update.<br/>
        /// Only cells with string type can be returned in delta mode. Delta mode returns<br/>
        /// only the changes made to the cell value rather than the full value.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deltaMode")]
        public bool? DeltaMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CellUpdatedEvent" /> class.
        /// </summary>
        /// <param name="cell">
        /// The cell that was updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deltaMode">
        /// Whether the event is a delta update.<br/>
        /// Only cells with string type can be returned in delta mode. Delta mode returns<br/>
        /// only the changes made to the cell value rather than the full value.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CellUpdatedEvent(
            global::Instill.Cell? cell,
            bool? deltaMode)
        {
            this.Cell = cell;
            this.DeltaMode = deltaMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellUpdatedEvent" /> class.
        /// </summary>
        public CellUpdatedEvent()
        {
        }
    }
}