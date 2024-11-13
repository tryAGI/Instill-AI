
#nullable enable

namespace Instill
{
    /// <summary>
    /// EventSpecification describes the JSON schema of component event setup and examples.
    /// </summary>
    public sealed partial class EventSpecification
    {
        /// <summary>
        /// JSON schema describing the component event setup data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupSchema")]
        public object? SetupSchema { get; set; }

        /// <summary>
        /// JSON schema describing the component event message data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageSchema")]
        public object? MessageSchema { get; set; }

        /// <summary>
        /// JSON schema describing the component event examples.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageExamples")]
        public global::System.Collections.Generic.IList<object>? MessageExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSpecification" /> class.
        /// </summary>
        /// <param name="setupSchema">
        /// JSON schema describing the component event setup data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="messageSchema">
        /// JSON schema describing the component event message data.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="messageExamples">
        /// JSON schema describing the component event examples.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EventSpecification(
            object? setupSchema,
            object? messageSchema,
            global::System.Collections.Generic.IList<object>? messageExamples)
        {
            this.SetupSchema = setupSchema;
            this.MessageSchema = messageSchema;
            this.MessageExamples = messageExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSpecification" /> class.
        /// </summary>
        public EventSpecification()
        {
        }
    }
}