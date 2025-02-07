
#nullable enable

namespace Instill
{
    /// <summary>
    /// TableUpdatedEvent represents an event for a table being updated.
    /// </summary>
    public sealed partial class TableUpdatedEvent
    {
        /// <summary>
        /// The table that was updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::Instill.Table? Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdatedEvent" /> class.
        /// </summary>
        /// <param name="table">
        /// The table that was updated.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableUpdatedEvent(
            global::Instill.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableUpdatedEvent" /> class.
        /// </summary>
        public TableUpdatedEvent()
        {
        }
    }
}