#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List public models<br/>
        /// Returns a paginated list of public models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="showDeleted"></param>
        /// <param name="filter"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListPublicModelsResponse> ModelPublicServiceListPublicModelsAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.ModelPublicServiceListPublicModelsView? view = default,
            bool? showDeleted = default,
            string? filter = default,
            global::Instill.ModelPublicServiceListPublicModelsVisibility? visibility = default,
            string? orderBy = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}