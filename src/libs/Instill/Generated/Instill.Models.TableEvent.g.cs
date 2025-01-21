
#nullable enable

namespace Instill
{
    /// <summary>
    /// TableEvent represents an event for a table.
    /// </summary>
    public sealed partial class TableEvent
    {
        /// <summary>
        /// The event type.<br/>
        /// In text/event-stream format, this maps to the `event` field.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// The ID of the event.<br/>
        /// In text/event-stream format, this maps to the `id` field.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The table that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableUpdatedEvent")]
        public global::Instill.TableUpdatedEvent? TableUpdatedEvent { get; set; }

        /// <summary>
        /// The table that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableDeletedEvent")]
        public object? TableDeletedEvent { get; set; }

        /// <summary>
        /// The column definitions that were updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinitionsUpdatedEvent")]
        public global::Instill.ColumnDefinitionsUpdatedEvent? ColumnDefinitionsUpdatedEvent { get; set; }

        /// <summary>
        /// The row that was inserted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowInsertedEvent")]
        public global::Instill.RowInsertedEvent? RowInsertedEvent { get; set; }

        /// <summary>
        /// The row that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowUpdatedEvent")]
        public global::Instill.RowUpdatedEvent? RowUpdatedEvent { get; set; }

        /// <summary>
        /// The row that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowDeletedEvent")]
        public global::Instill.RowDeletedEvent? RowDeletedEvent { get; set; }

        /// <summary>
        /// The rows that were moved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowsMovedEvent")]
        public global::Instill.RowsMovedEvent? RowsMovedEvent { get; set; }

        /// <summary>
        /// The cell that was updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cellUpdatedEvent")]
        public global::Instill.CellUpdatedEvent? CellUpdatedEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableEvent" /> class.
        /// </summary>
        /// <param name="event">
        /// The event type.<br/>
        /// In text/event-stream format, this maps to the `event` field.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// The ID of the event.<br/>
        /// In text/event-stream format, this maps to the `id` field.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tableUpdatedEvent">
        /// The table that was updated.
        /// </param>
        /// <param name="tableDeletedEvent">
        /// The table that was deleted.
        /// </param>
        /// <param name="columnDefinitionsUpdatedEvent">
        /// The column definitions that were updated.
        /// </param>
        /// <param name="rowInsertedEvent">
        /// The row that was inserted.
        /// </param>
        /// <param name="rowUpdatedEvent">
        /// The row that was updated.
        /// </param>
        /// <param name="rowDeletedEvent">
        /// The row that was deleted.
        /// </param>
        /// <param name="rowsMovedEvent">
        /// The rows that were moved.
        /// </param>
        /// <param name="cellUpdatedEvent">
        /// The cell that was updated.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TableEvent(
            string? @event,
            string? id,
            global::Instill.TableUpdatedEvent? tableUpdatedEvent,
            object? tableDeletedEvent,
            global::Instill.ColumnDefinitionsUpdatedEvent? columnDefinitionsUpdatedEvent,
            global::Instill.RowInsertedEvent? rowInsertedEvent,
            global::Instill.RowUpdatedEvent? rowUpdatedEvent,
            global::Instill.RowDeletedEvent? rowDeletedEvent,
            global::Instill.RowsMovedEvent? rowsMovedEvent,
            global::Instill.CellUpdatedEvent? cellUpdatedEvent)
        {
            this.Event = @event;
            this.Id = id;
            this.TableUpdatedEvent = tableUpdatedEvent;
            this.TableDeletedEvent = tableDeletedEvent;
            this.ColumnDefinitionsUpdatedEvent = columnDefinitionsUpdatedEvent;
            this.RowInsertedEvent = rowInsertedEvent;
            this.RowUpdatedEvent = rowUpdatedEvent;
            this.RowDeletedEvent = rowDeletedEvent;
            this.RowsMovedEvent = rowsMovedEvent;
            this.CellUpdatedEvent = cellUpdatedEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableEvent" /> class.
        /// </summary>
        public TableEvent()
        {
        }
    }
}