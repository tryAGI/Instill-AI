#nullable enable

namespace Instill
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// List namespace connections<br/>
        /// Returns a paginated list of connections created by a namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListNamespaceConnectionsResponse> PipelinePublicServiceListNamespaceConnectionsAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}