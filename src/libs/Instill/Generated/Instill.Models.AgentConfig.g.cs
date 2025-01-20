
#nullable enable

namespace Instill
{
    /// <summary>
    /// AgentConfig represents the config for the chat agent.
    /// </summary>
    public sealed partial class AgentConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.Dictionary<string, string>? Connections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="connections">
        /// connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AgentConfig(
            string? instructions,
            global::System.Collections.Generic.Dictionary<string, string>? connections)
        {
            this.Instructions = instructions;
            this.Connections = connections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfig" /> class.
        /// </summary>
        public AgentConfig()
        {
        }
    }
}