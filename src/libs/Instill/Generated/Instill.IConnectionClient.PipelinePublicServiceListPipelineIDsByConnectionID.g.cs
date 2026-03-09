#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// List pipelines that reference a connection<br/>
        /// Returns a paginated list with the IDs of the pipelines that reference a<br/>
        /// given connection. All the pipelines will belong to the same namespace as<br/>
        /// the connection.
        /// </summary>
        /// <param name="namespaceId1"></param>
        /// <param name="connectionId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.PipelineV1betaListPipelineIDsByConnectionIDResponse> PipelinePublicServiceListPipelineIDsByConnectionIDAsync(
            string namespaceId1,
            string connectionId,
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}