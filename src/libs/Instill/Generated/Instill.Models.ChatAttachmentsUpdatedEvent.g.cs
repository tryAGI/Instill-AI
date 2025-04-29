
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAttachmentsUpdatedEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::Instill.ChatAttachments? Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAttachmentsUpdatedEvent" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="attachments">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAttachmentsUpdatedEvent(
            global::System.DateTime? createTime,
            global::Instill.ChatAttachments? attachments)
        {
            this.CreateTime = createTime;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAttachmentsUpdatedEvent" /> class.
        /// </summary>
        public ChatAttachmentsUpdatedEvent()
        {
        }
    }
}