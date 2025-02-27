
#nullable enable

namespace Instill
{
    /// <summary>
    /// PipelineRun represents a single execution of a pipeline.
    /// </summary>
    public sealed partial class PipelineRun
    {
        /// <summary>
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineRunUid")]
        public string? PipelineRunUid { get; set; }

        /// <summary>
        /// Pipeline version used in the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineVersion")]
        public string? PipelineVersion { get; set; }

        /// <summary>
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.RunStatusJsonConverter))]
        public global::Instill.RunStatus? Status { get; set; }

        /// <summary>
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.RunSourceJsonConverter))]
        public global::Instill.RunSource? Source { get; set; }

        /// <summary>
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Runner ID. The authenticated user that triggered the run. If current<br/>
        /// viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnerId")]
        public string? RunnerId { get; set; }

        /// <summary>
        /// Pipeline input parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// Pipeline inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Snapshot of the pipeline recipe used for this run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipeSnapshot")]
        public object? RecipeSnapshot { get; set; }

        /// <summary>
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completeTime")]
        public global::System.DateTime? CompleteTime { get; set; }

        /// <summary>
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecification")]
        public global::Instill.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Requester ID. The namespace used to trigger the run. This field might be<br/>
        /// empty if the pipeline run belongs to a deleted namespace.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requesterId")]
        public string? RequesterId { get; set; }

        /// <summary>
        /// ID of the namespace that owns the pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineNamespaceId")]
        public string? PipelineNamespaceId { get; set; }

        /// <summary>
        /// Expiration time for the blob data associated with the pipeline run (e.g.<br/>
        /// input data, recipe). When the run is accessed after the expiration, that<br/>
        /// information will be empty, but this field will allow the user identify<br/>
        /// that the data isn't there because it has expired.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobDataExpirationTime")]
        public global::System.DateTime? BlobDataExpirationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        /// <param name="pipelineRunUid">
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineVersion">
        /// Pipeline version used in the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source">
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="runnerId">
        /// Runner ID. The authenticated user that triggered the run. If current<br/>
        /// viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputs">
        /// Pipeline input parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputs">
        /// Pipeline inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="recipeSnapshot">
        /// Snapshot of the pipeline recipe used for this run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completeTime">
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineId">
        /// Included only in responses
        /// </param>
        /// <param name="requesterId">
        /// Requester ID. The namespace used to trigger the run. This field might be<br/>
        /// empty if the pipeline run belongs to a deleted namespace.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineNamespaceId">
        /// ID of the namespace that owns the pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="blobDataExpirationTime">
        /// Expiration time for the blob data associated with the pipeline run (e.g.<br/>
        /// input data, recipe). When the run is accessed after the expiration, that<br/>
        /// information will be empty, but this field will allow the user identify<br/>
        /// that the data isn't there because it has expired.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineRun(
            string? pipelineRunUid,
            string? pipelineVersion,
            global::Instill.RunStatus? status,
            global::Instill.RunSource? source,
            int? totalDuration,
            string? runnerId,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<object>? outputs,
            object? recipeSnapshot,
            global::System.DateTime? startTime,
            global::System.DateTime? completeTime,
            string? error,
            float? creditAmount,
            global::Instill.DataSpecification? dataSpecification,
            string? pipelineId,
            string? requesterId,
            string? pipelineNamespaceId,
            global::System.DateTime? blobDataExpirationTime)
        {
            this.PipelineRunUid = pipelineRunUid;
            this.PipelineVersion = pipelineVersion;
            this.Status = status;
            this.Source = source;
            this.TotalDuration = totalDuration;
            this.RunnerId = runnerId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.RecipeSnapshot = recipeSnapshot;
            this.StartTime = startTime;
            this.CompleteTime = completeTime;
            this.Error = error;
            this.CreditAmount = creditAmount;
            this.DataSpecification = dataSpecification;
            this.PipelineId = pipelineId;
            this.RequesterId = requesterId;
            this.PipelineNamespaceId = pipelineNamespaceId;
            this.BlobDataExpirationTime = blobDataExpirationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        public PipelineRun()
        {
        }
    }
}