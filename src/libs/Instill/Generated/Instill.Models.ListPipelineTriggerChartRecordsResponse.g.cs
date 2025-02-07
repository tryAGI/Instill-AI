
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListPipelineTriggerChartRecordsResponse contains a list of pipeline trigger<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListPipelineTriggerChartRecordsResponse
    {
        /// <summary>
        /// Pipeline trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like pipeline ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the pipeline<br/>
        /// ID, trigger mode, final status or other fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineTriggerChartRecords")]
        public global::System.Collections.Generic.IList<global::Instill.PipelineTriggerChartRecord>? PipelineTriggerChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerChartRecordsResponse" /> class.
        /// </summary>
        /// <param name="pipelineTriggerChartRecords">
        /// Pipeline trigger counts. Until we allow filtering or grouping by fields<br/>
        /// like pipeline ID, this list will contain only one element with the<br/>
        /// timeline of trigger counts for a given requester, regardless the pipeline<br/>
        /// ID, trigger mode, final status or other fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPipelineTriggerChartRecordsResponse(
            global::System.Collections.Generic.IList<global::Instill.PipelineTriggerChartRecord>? pipelineTriggerChartRecords)
        {
            this.PipelineTriggerChartRecords = pipelineTriggerChartRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerChartRecordsResponse" /> class.
        /// </summary>
        public ListPipelineTriggerChartRecordsResponse()
        {
        }
    }
}