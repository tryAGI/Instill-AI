#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List Model Runs<br/>
        /// Returns a paginated list of runs for a given model. When the requester is<br/>
        /// the owner of the model, they will be able to all the model runs,<br/>
        /// regardless who requested the trigger (the view will be partial to hide<br/>
        /// sensitive data like e.g. the trigger input and output). Other requesters<br/>
        /// will only be able to see the runs requested by themselves.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListModelRunsResponse> ModelPublicServiceListModelRunsAsync(
            string namespaceId,
            string modelId,
            int? pageSize = default,
            int? page = default,
            string? orderBy = default,
            string? filter = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}