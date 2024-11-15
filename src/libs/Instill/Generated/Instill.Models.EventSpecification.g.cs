
#nullable enable

namespace Instill
{
    /// <summary>
    /// EventSpecification describes the JSON schema of component event setup and examples.
    /// </summary>
    public sealed partial class EventSpecification
    {
        /// <summary>
        /// Event title.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Event description.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON schema describing the component event config data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configSchema")]
        public object? ConfigSchema { get; set; }

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
        /// <param name="title">
        /// Event title.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Event description.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="configSchema">
        /// JSON schema describing the component event config data.<br/>
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
            string? title,
            string? description,
            object? configSchema,
            object? messageSchema,
            global::System.Collections.Generic.IList<object>? messageExamples)
        {
            this.Title = title;
            this.Description = description;
            this.ConfigSchema = configSchema;
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