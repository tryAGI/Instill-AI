#nullable enable

namespace Instill
{
    public partial interface IMetricClient
    {
        /// <summary>
        /// List pipeline trigger metrics<br/>
        /// Returns a paginated list of pipeline executions aggregated by pipeline ID.<br/>
        /// NOTE: This method is deprecated and will be retired soon.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListPipelineTriggerTableRecordsResponse> ListPipelineTriggerTableRecordsAsync(
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}