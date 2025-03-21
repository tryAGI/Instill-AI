
#nullable enable

namespace Instill
{
    /// <summary>
    /// The configuration for the agent.
    /// </summary>
    public sealed partial class ColumnDefinitionAgentConfig
    {
        /// <summary>
        /// The instructions for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Whether to enable web search for the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWebSearch")]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinitionAgentConfig" /> class.
        /// </summary>
        /// <param name="instructions">
        /// The instructions for the agent.
        /// </param>
        /// <param name="enableWebSearch">
        /// Whether to enable web search for the column.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColumnDefinitionAgentConfig(
            string? instructions,
            bool? enableWebSearch)
        {
            this.Instructions = instructions;
            this.EnableWebSearch = enableWebSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinitionAgentConfig" /> class.
        /// </summary>
        public ColumnDefinitionAgentConfig()
        {
        }
    }
}