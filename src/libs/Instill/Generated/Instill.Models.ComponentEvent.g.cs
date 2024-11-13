
#nullable enable

namespace Instill
{
    /// <summary>
    /// ComponentEvent contains information about an event that a component can<br/>
    /// produce.
    /// </summary>
    public sealed partial class ComponentEvent
    {
        /// <summary>
        /// The event name, e.g. `EVENT_NEW`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Title is the event name in a human-friendly format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description contains information about the event.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentEvent" /> class.
        /// </summary>
        /// <param name="name">
        /// The event name, e.g. `EVENT_NEW`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Title is the event name in a human-friendly format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Description contains information about the event.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ComponentEvent(
            string? name,
            string? title,
            string? description)
        {
            this.Name = name;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentEvent" /> class.
        /// </summary>
        public ComponentEvent()
        {
        }
    }
}