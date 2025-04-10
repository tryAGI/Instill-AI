
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallResponse
    {
        /// <summary>
        /// Model inference outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOutputs")]
        public global::System.Collections.Generic.IList<object>? TaskOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallResponse" /> class.
        /// </summary>
        /// <param name="taskOutputs">
        /// Model inference outputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallResponse(
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallResponse" /> class.
        /// </summary>
        public CallResponse()
        {
        }
    }
}