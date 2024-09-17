
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListCreditConsumptionChartRecordsResponse contains a list of credit consumption<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListCreditConsumptionChartRecordsResponse
    {
        /// <summary>
        /// Credit consumption timelines, aggregated by source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditConsumptionChartRecords")]
        public global::System.Collections.Generic.IList<global::Instill.CreditConsumptionChartRecord>? CreditConsumptionChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}