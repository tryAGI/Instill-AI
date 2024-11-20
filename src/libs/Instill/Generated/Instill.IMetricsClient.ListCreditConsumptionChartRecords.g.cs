#nullable enable

namespace Instill
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// List Instill Credit consumption time charts<br/>
        /// Returns a timeline of Instill Credit consumption for a given owner. The<br/>
        /// response will contain one set of records (datapoints) per consumption<br/>
        /// source (e.g. "pipeline", "model"). Each datapoint represents the amount<br/>
        /// consumed in a time bucket.<br/>
        /// This endpoint is only exposed on Instill Cloud.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="aggregationWindow"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListCreditConsumptionChartRecordsResponse> ListCreditConsumptionChartRecordsAsync(
            string namespaceId,
            string? aggregationWindow = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}