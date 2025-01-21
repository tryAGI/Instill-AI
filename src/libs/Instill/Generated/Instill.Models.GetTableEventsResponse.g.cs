
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetTableEventsResponse contains the events for a table.
    /// </summary>
    public sealed partial class GetTableEventsResponse
    {
        /// <summary>
        /// The events for the table.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public global::Instill.TableEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableEventsResponse" /> class.
        /// </summary>
        /// <param name="event">
        /// The events for the table.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTableEventsResponse(
            global::Instill.TableEvent? @event)
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableEventsResponse" /> class.
        /// </summary>
        public GetTableEventsResponse()
        {
        }
    }
}