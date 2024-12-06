
#nullable enable

namespace Instill
{
    /// <summary>
    /// AIAgentSettings represents the settings for the AI agent.
    /// </summary>
    public sealed partial class AIAgentSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUids")]
        public global::System.Collections.Generic.IList<string>? CatalogUids { get; set; }

        /// <summary>
        /// connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public global::System.Collections.Generic.Dictionary<string, string>? Connections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAgentSettings" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="catalogUids"></param>
        /// <param name="connections">
        /// connection key(used connection id in recipe) and value(connection uid from namespace).
        /// </param>
        /// <param name="toolIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AIAgentSettings(
            string? instructions,
            global::System.Collections.Generic.IList<string>? catalogUids,
            global::System.Collections.Generic.Dictionary<string, string>? connections,
            global::System.Collections.Generic.IList<string>? toolIds)
        {
            this.Instructions = instructions;
            this.CatalogUids = catalogUids;
            this.Connections = connections;
            this.ToolIds = toolIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIAgentSettings" /> class.
        /// </summary>
        public AIAgentSettings()
        {
        }
    }
}