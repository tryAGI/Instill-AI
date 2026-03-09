#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List accessible pipelines<br/>
        /// Returns a paginated list of pipelines that are visible to the requester.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListPublicPipelinesResponse> PipelinePublicServiceListPublicPipelinesAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.PipelinePublicServiceListPublicPipelinesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::Instill.PipelinePublicServiceListPublicPipelinesVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}