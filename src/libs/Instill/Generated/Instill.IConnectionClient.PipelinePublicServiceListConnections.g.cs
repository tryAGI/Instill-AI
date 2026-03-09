#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// List connections<br/>
        /// Returns a paginated list of connections created by a namespace.
        /// </summary>
        /// <param name="parent1"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListConnectionsResponse> PipelinePublicServiceListConnectionsAsync(
            string parent1,
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}