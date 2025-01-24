
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatUid")]
        public string? ChatUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Instill.AgentV1alphaMessage? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageResponse" /> class.
        /// </summary>
        /// <param name="chatUid"></param>
        /// <param name="message"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateMessageResponse(
            string? chatUid,
            global::Instill.AgentV1alphaMessage? message)
        {
            this.ChatUid = chatUid;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageResponse" /> class.
        /// </summary>
        public CreateMessageResponse()
        {
        }
    }
}