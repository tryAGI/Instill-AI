#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List Model Runs By Requester<br/>
        /// Returns a paginated list of runs requested by a namespace. The response<br/>
        /// may contain runs from several models.
        /// </summary>
        /// <param name="requester"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListModelRunsByRequesterResponse> ModelPublicServiceListModelRunsByRequesterAsync(
            string requester,
            int? pageSize = default,
            int? page = default,
            string? orderBy = default,
            string? filter = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}