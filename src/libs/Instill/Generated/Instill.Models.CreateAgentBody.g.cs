
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateAgentRequest represents a request to create a agent.
    /// </summary>
    public sealed partial class CreateAgentBody
    {
        /// <summary>
        /// The agent display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The agent description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The agent tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The agent metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentApp")]
        public global::Instill.AIAgentAppMetadata? AiAgentApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBody" /> class.
        /// </summary>
        /// <param name="displayName">
        /// The agent display name.
        /// </param>
        /// <param name="description">
        /// The agent description.
        /// </param>
        /// <param name="tags">
        /// The agent tags.
        /// </param>
        /// <param name="aiAgentApp">
        /// The agent metadata.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateAgentBody(
            string? displayName,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.AIAgentAppMetadata? aiAgentApp)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Tags = tags;
            this.AiAgentApp = aiAgentApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBody" /> class.
        /// </summary>
        public CreateAgentBody()
        {
        }
    }
}