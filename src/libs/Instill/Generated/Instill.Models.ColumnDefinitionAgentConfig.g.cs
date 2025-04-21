
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Whether to enable web search for the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWebSearch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableWebSearch { get; set; }

        /// <summary>
        /// Whether to enable automatic computation for the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAutomaticComputation")]
        public bool? EnableAutomaticComputation { get; set; }

        /// <summary>
        /// The context for the agent. This setting is only used if enable_automatic_computation is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Instill.Context? Context { get; set; }

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
        /// <param name="enableAutomaticComputation">
        /// Whether to enable automatic computation for the column.
        /// </param>
        /// <param name="context">
        /// The context for the agent. This setting is only used if enable_automatic_computation is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColumnDefinitionAgentConfig(
            string instructions,
            bool enableWebSearch,
            bool? enableAutomaticComputation,
            global::Instill.Context? context)
        {
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.EnableWebSearch = enableWebSearch;
            this.EnableAutomaticComputation = enableAutomaticComputation;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinitionAgentConfig" /> class.
        /// </summary>
        public ColumnDefinitionAgentConfig()
        {
        }
    }
}