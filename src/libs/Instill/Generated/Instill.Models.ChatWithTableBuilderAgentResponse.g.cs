
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChatWithTableBuilderAgentResponse contains the response from the table builder agent.
    /// </summary>
    public sealed partial class ChatWithTableBuilderAgentResponse
    {
        /// <summary>
        /// The response from the table builder agent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public global::Instill.ChatEvent? Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWithTableBuilderAgentResponse" /> class.
        /// </summary>
        /// <param name="event">
        /// The response from the table builder agent.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatWithTableBuilderAgentResponse(
            global::Instill.ChatEvent? @event)
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWithTableBuilderAgentResponse" /> class.
        /// </summary>
        public ChatWithTableBuilderAgentResponse()
        {
        }
    }
}