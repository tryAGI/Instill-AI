
#nullable enable

namespace Instill
{
    /// <summary>
    /// The configuration for the agent.
    /// </summary>
    public sealed partial class TableAgentConfig
    {
        /// <summary>
        /// Whether to enable faithfulness checking for the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableFaithfulnessChecking")]
        public bool? EnableFaithfulnessChecking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAgentConfig" /> class.
        /// </summary>
        /// <param name="enableFaithfulnessChecking">
        /// Whether to enable faithfulness checking for the table.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableAgentConfig(
            bool? enableFaithfulnessChecking)
        {
            this.EnableFaithfulnessChecking = enableFaithfulnessChecking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAgentConfig" /> class.
        /// </summary>
        public TableAgentConfig()
        {
        }
    }
}