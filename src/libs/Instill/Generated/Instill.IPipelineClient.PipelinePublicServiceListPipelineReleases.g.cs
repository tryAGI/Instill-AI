#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List the releases in a pipeline<br/>
        /// Lists the commited versions of a pipeline, identified by its resource<br/>
        /// name, which is formed by the parent namespace and ID of the pipeline.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListPipelineReleasesResponse> PipelinePublicServiceListPipelineReleasesAsync(
            string parent,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.PipelinePublicServiceListPipelineReleasesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}