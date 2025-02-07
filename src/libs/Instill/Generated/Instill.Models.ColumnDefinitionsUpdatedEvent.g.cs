
#nullable enable

namespace Instill
{
    /// <summary>
    /// ColumnDefinitionsUpdatedEvent represents an event for column definitions being updated.
    /// </summary>
    public sealed partial class ColumnDefinitionsUpdatedEvent
    {
        /// <summary>
        /// The column definitions that were updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinitions")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? ColumnDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinitionsUpdatedEvent" /> class.
        /// </summary>
        /// <param name="columnDefinitions">
        /// The column definitions that were updated.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColumnDefinitionsUpdatedEvent(
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? columnDefinitions)
        {
            this.ColumnDefinitions = columnDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinitionsUpdatedEvent" /> class.
        /// </summary>
        public ColumnDefinitionsUpdatedEvent()
        {
        }
    }
}