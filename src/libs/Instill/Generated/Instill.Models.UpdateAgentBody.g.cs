
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateAgentRequest represents a request to update a agent.
    /// </summary>
    public sealed partial class UpdateAgentBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("aiAgentSettings")]
        public global::Instill.AIAgentSettings? AiAgentSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentBody" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="aiAgentSettings"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateAgentBody(
            string? displayName,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::Instill.AIAgentSettings? aiAgentSettings)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Tags = tags;
            this.AiAgentSettings = aiAgentSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentBody" /> class.
        /// </summary>
        public UpdateAgentBody()
        {
        }
    }
}