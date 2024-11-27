
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateAgentResponse represents a response for updating a agent.
    /// </summary>
    public sealed partial class UpdateAgentResponse
    {
        /// <summary>
        /// The updated agent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Instill.Agent? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentResponse" /> class.
        /// </summary>
        /// <param name="agent">
        /// The updated agent.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateAgentResponse(
            global::Instill.Agent? agent)
        {
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentResponse" /> class.
        /// </summary>
        public UpdateAgentResponse()
        {
        }
    }
}