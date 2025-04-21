
#nullable enable

namespace Instill
{
    /// <summary>
    /// The context for the agent.
    /// </summary>
    public sealed partial class Context
    {
        /// <summary>
        /// The column names to include in the context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<string>? Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        /// <param name="columns">
        /// The column names to include in the context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Context(
            global::System.Collections.Generic.IList<string>? columns)
        {
            this.Columns = columns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Context" /> class.
        /// </summary>
        public Context()
        {
        }
    }
}