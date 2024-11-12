
#nullable enable

namespace Instill
{
    /// <summary>
    /// TriggerNamespaceLatestModelBinaryFileUploadResponse contains the model inference results.
    /// </summary>
    public sealed partial class TriggerNamespaceLatestModelBinaryFileUploadResponse
    {
        /// <summary>
        /// Task type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.AITaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.AITask Task { get; set; }

        /// <summary>
        /// Deleteted field.<br/>
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
        /// Initializes a new instance of the <see cref="TriggerNamespaceLatestModelBinaryFileUploadResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// Task type.
        /// </param>
        /// <param name="taskOutputs">
        /// Deleteted field.<br/>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerNamespaceLatestModelBinaryFileUploadResponse(
            global::Instill.AITask task,
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.Task = task;
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceLatestModelBinaryFileUploadResponse" /> class.
        /// </summary>
        public TriggerNamespaceLatestModelBinaryFileUploadResponse()
        {
        }
    }
}