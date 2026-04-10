#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get a file<br/>
        /// Returns the details of a file.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="view"></param>
        /// <param name="storageProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetFileResponse> ArtifactPublicServiceGetFileAsync(
            string name1,
            global::Instill.ArtifactPublicServiceGetFileView? view = default,
            global::Instill.ArtifactPublicServiceGetFileStorageProvider? storageProvider = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}