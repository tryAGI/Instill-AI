
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentV1alphaMessage
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatUid")]
        public string? ChatUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.MessageTypeJsonConverter))]
        public global::Instill.MessageType Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msgSenderUid")]
        public string? MsgSenderUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Instill.Citation>? Citations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Instill.ChatContext? Context { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::Instill.ChatAttachments? Attachments { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWebSearch")]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// internal flag for the message, if true, the message is the intermediate message happened in the LLM flow.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawMessage")]
        public object? RawMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1alphaMessage" /> class.
        /// </summary>
        /// <param name="uid">
        /// Included only in responses
        /// </param>
        /// <param name="chatUid">
        /// Included only in responses
        /// </param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        /// <param name="msgSenderUid">
        /// Included only in responses
        /// </param>
        /// <param name="citations">
        /// Included only in responses
        /// </param>
        /// <param name="context">
        /// Included only in responses
        /// </param>
        /// <param name="attachments">
        /// Included only in responses
        /// </param>
        /// <param name="enableWebSearch">
        /// Included only in responses
        /// </param>
        /// <param name="internal">
        /// internal flag for the message, if true, the message is the intermediate message happened in the LLM flow.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="rawMessage">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentV1alphaMessage(
            string content,
            string role,
            string? uid,
            string? chatUid,
            global::Instill.MessageType type,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? msgSenderUid,
            global::System.Collections.Generic.IList<global::Instill.Citation>? citations,
            global::Instill.ChatContext? context,
            global::Instill.ChatAttachments? attachments,
            bool? enableWebSearch,
            bool? @internal,
            object? rawMessage)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Uid = uid;
            this.ChatUid = chatUid;
            this.Type = type;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.MsgSenderUid = msgSenderUid;
            this.Citations = citations;
            this.Context = context;
            this.Attachments = attachments;
            this.EnableWebSearch = enableWebSearch;
            this.Internal = @internal;
            this.RawMessage = rawMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentV1alphaMessage" /> class.
        /// </summary>
        public AgentV1alphaMessage()
        {
        }
    }
}