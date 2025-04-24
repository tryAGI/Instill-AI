
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatOutputUpdatedEvent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputChunkDelta")]
        public string OutputChunkDelta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutputUpdatedEvent" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="outputChunkDelta">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatOutputUpdatedEvent(
            global::System.DateTime? createTime,
            string outputChunkDelta = default!)
        {
            this.CreateTime = createTime;
            this.OutputChunkDelta = outputChunkDelta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutputUpdatedEvent" /> class.
        /// </summary>
        public ChatOutputUpdatedEvent()
        {
        }
    }
}