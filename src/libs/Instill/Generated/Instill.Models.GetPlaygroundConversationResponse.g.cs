
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetPlaygroundConversationResponse represents a response for getting a playground conversation.
    /// </summary>
    public sealed partial class GetPlaygroundConversationResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::Instill.Conversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlaygroundConversationResponse" /> class.
        /// </summary>
        /// <param name="conversation">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetPlaygroundConversationResponse(
            global::Instill.Conversation? conversation)
        {
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPlaygroundConversationResponse" /> class.
        /// </summary>
        public GetPlaygroundConversationResponse()
        {
        }
    }
}