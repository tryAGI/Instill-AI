
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatReplanTriggeredEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfReplan")]
        public long? NumberOfReplan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReplanTriggeredEvent" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="numberOfReplan">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatReplanTriggeredEvent(
            global::System.DateTime? createTime,
            long? numberOfReplan)
        {
            this.CreateTime = createTime;
            this.NumberOfReplan = numberOfReplan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReplanTriggeredEvent" /> class.
        /// </summary>
        public ChatReplanTriggeredEvent()
        {
        }
    }
}