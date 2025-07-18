
#nullable enable

namespace Instill
{
    /// <summary>
    /// PipelineTriggerChartRecord represents a timeline of pipeline triggers. It<br/>
    /// contains a collection of (timestamp, count) pairs that represent the total<br/>
    /// pipeline triggers in a given time bucket.
    /// </summary>
    public sealed partial class PipelineTriggerChartRecord
    {
        /// <summary>
        /// This field will be present when the information is grouped by pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Time buckets.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeBuckets")]
        public global::System.Collections.Generic.IList<global::System.DateTime>? TimeBuckets { get; set; }

        /// <summary>
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerCounts")]
        public global::System.Collections.Generic.IList<int>? TriggerCounts { get; set; }

        /// <summary>
        /// The ID of the namespace that requested the pipeline triggers.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requesterId")]
        public string? RequesterId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerChartRecord" /> class.
        /// </summary>
        /// <param name="pipelineId">
        /// This field will be present when the information is grouped by pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="timeBuckets">
        /// Time buckets.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="triggerCounts">
        /// Aggregated trigger count in each time bucket.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requesterId">
        /// The ID of the namespace that requested the pipeline triggers.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineTriggerChartRecord(
            string? pipelineId,
            global::System.Collections.Generic.IList<global::System.DateTime>? timeBuckets,
            global::System.Collections.Generic.IList<int>? triggerCounts,
            string? requesterId)
        {
            this.PipelineId = pipelineId;
            this.TimeBuckets = timeBuckets;
            this.TriggerCounts = triggerCounts;
            this.RequesterId = requesterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTriggerChartRecord" /> class.
        /// </summary>
        public PipelineTriggerChartRecord()
        {
        }
    }
}