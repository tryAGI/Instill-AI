#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List Pipeline Runs<br/>
        /// Returns a paginated list of runs for a given pipeline. When the requester<br/>
        /// is the owner of the pipeline, they will be able to all the pipeline runs,<br/>
        /// regardless who requested the trigger (the view will be partial to hide<br/>
        /// sensitive data like e.g. the trigger input and output). Other requesters<br/>
        /// will only be able to see the runs requested by themselves.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListPipelineRunsResponse> PipelinePublicServiceListPipelineRunsAsync(
            string namespaceId,
            string pipelineId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}