
#nullable enable

namespace Instill
{
    /// <summary>
    /// ModelRun contains information about a run of models.
    /// </summary>
    public sealed partial class ModelRun
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique identifier for each run (immutable).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Model run created time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Model run updated time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Runner who triggered the run.<br/>
        /// Full resource name: users/{user}.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner")]
        public string? Runner { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Requester namespace.<br/>
        /// Full resource name: namespaces/{namespace}.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        public string? Requester { get; set; }

        /// <summary>
        /// Model run status.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.RunStatusJsonConverter))]
        public global::Instill.RunStatus? Status { get; set; }

        /// <summary>
        /// Run source.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.RunSourceJsonConverter))]
        public global::Instill.RunSource? Source { get; set; }

        /// <summary>
        /// Run total duration in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Run end time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// The amount of Instill Credit consumed by the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Error message occurred during model run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The model version identifier, which is same as image tag.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Model inference input.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskInputs")]
        public global::System.Collections.Generic.IList<object>? TaskInputs { get; set; }

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
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Unique identifier for each run (immutable).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Model run created time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Model run updated time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="runner">
        /// Runner who triggered the run.<br/>
        /// Full resource name: users/{user}.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="model">
        /// Included only in responses
        /// </param>
        /// <param name="requester">
        /// Requester namespace.<br/>
        /// Full resource name: namespaces/{namespace}.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Model run status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source">
        /// Run source.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Run total duration in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endTime">
        /// Run end time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// The amount of Instill Credit consumed by the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message occurred during model run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="version">
        /// The model version identifier, which is same as image tag.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="taskInputs">
        /// Model inference input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="taskOutputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRun(
            string? name,
            string? id,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? runner,
            string? model,
            string? requester,
            global::Instill.RunStatus? status,
            global::Instill.RunSource? source,
            int? totalDuration,
            global::System.DateTime? endTime,
            float? creditAmount,
            string? error,
            string? version,
            global::System.Collections.Generic.IList<object>? taskInputs,
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.Name = name;
            this.Id = id;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Runner = runner;
            this.Model = model;
            this.Requester = requester;
            this.Status = status;
            this.Source = source;
            this.TotalDuration = totalDuration;
            this.EndTime = endTime;
            this.CreditAmount = creditAmount;
            this.Error = error;
            this.Version = version;
            this.TaskInputs = taskInputs;
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        public ModelRun()
        {
        }
    }
}