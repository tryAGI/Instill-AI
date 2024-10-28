#nullable enable

namespace Instill
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// List Component runs<br/>
        /// Returns the information of each component execution within a pipeline run.
        /// </summary>
        /// <param name="pipelineRunId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="view"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListComponentRunsResponse> PipelinePublicServiceListComponentRunsAsync(
            string pipelineRunId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::Instill.PipelinePublicServiceListComponentRunsView? view = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}