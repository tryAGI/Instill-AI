
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateAgentRequest represents a request to create a agent.
    /// </summary>
    public sealed partial class CreateAgentBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentMetadata")]
        public global::Instill.AIAgentAppMetadata? AiAgentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBody" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="aiAgentMetadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateAgentBody(
            string? displayName,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.AIAgentAppMetadata? aiAgentMetadata)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Tags = tags;
            this.AiAgentMetadata = aiAgentMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentBody" /> class.
        /// </summary>
        public CreateAgentBody()
        {
        }
    }
}