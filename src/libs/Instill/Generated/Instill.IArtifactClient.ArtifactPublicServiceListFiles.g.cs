#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// List files<br/>
        /// Returns a paginated list of files.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="view"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListFilesResponse> ArtifactPublicServiceListFilesAsync(
            string parent,
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::Instill.ArtifactPublicServiceListFilesView? view = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}