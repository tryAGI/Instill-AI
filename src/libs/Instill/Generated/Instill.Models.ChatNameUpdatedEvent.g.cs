
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatNameUpdatedEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNameUpdatedEvent" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatNameUpdatedEvent(
            global::System.DateTime? createTime,
            string? name)
        {
            this.CreateTime = createTime;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatNameUpdatedEvent" /> class.
        /// </summary>
        public ChatNameUpdatedEvent()
        {
        }
    }
}