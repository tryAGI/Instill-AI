
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChatWithAgentResponse contains the chatbot response.
    /// </summary>
    public sealed partial class ChatWithAgentResponse
    {
        /// <summary>
        /// Conversation responses.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWithAgentResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Conversation responses.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatWithAgentResponse(
            global::System.Collections.Generic.IList<object>? outputs)
        {
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWithAgentResponse" /> class.
        /// </summary>
        public ChatWithAgentResponse()
        {
        }
    }
}