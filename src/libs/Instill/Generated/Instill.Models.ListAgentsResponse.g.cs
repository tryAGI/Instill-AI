
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListAgentsResponse represents a response for listing agents.
    /// </summary>
    public sealed partial class ListAgentsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        public global::System.Collections.Generic.IList<global::Instill.Agent>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListAgentsResponse(
            global::System.Collections.Generic.IList<global::Instill.Agent>? agents)
        {
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponse" /> class.
        /// </summary>
        public ListAgentsResponse()
        {
        }
    }
}