
#nullable enable

namespace Instill
{
    /// <summary>
    /// TableDeletedEvent represents an event for a table being deleted.
    /// </summary>
    public sealed partial class TableDeletedEvent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}