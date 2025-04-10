
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerNamespaceModelBinaryFileUploadResponse contains the model inference<br/>
    /// results.
    /// </summary>
    public sealed partial class TriggerNamespaceModelBinaryFileUploadResponse
    {
        /// <summary>
        /// Task type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AITaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.AITask Task { get; set; }

        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOutputs")]
        public global::System.Collections.Generic.IList<object>? TaskOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceModelBinaryFileUploadResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// Task type.
        /// </param>
        /// <param name="taskOutputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerNamespaceModelBinaryFileUploadResponse(
            global::Instill.AITask task,
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.Task = task;
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceModelBinaryFileUploadResponse" /> class.
        /// </summary>
        public TriggerNamespaceModelBinaryFileUploadResponse()
        {
        }
    }
}