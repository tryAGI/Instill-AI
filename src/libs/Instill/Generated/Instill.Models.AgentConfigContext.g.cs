
#nullable enable

namespace Instill
{
    /// <summary>
    /// The context for the agent.
    /// </summary>
    public sealed partial class AgentConfigContext
    {
        /// <summary>
        /// The column uids to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnUids")]
        public global::System.Collections.Generic.IList<string>? ColumnUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigContext" /> class.
        /// </summary>
        /// <param name="columnUids">
        /// The column uids to include in the context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigContext(
            global::System.Collections.Generic.IList<string>? columnUids)
        {
            this.ColumnUids = columnUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigContext" /> class.
        /// </summary>
        public AgentConfigContext()
        {
        }
    }
}