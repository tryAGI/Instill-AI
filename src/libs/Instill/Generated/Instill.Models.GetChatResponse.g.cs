
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChatResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public global::Instill.Chat? Chat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatResponse" /> class.
        /// </summary>
        /// <param name="chat">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChatResponse(
            global::Instill.Chat? chat)
        {
            this.Chat = chat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatResponse" /> class.
        /// </summary>
        public GetChatResponse()
        {
        }
    }
}