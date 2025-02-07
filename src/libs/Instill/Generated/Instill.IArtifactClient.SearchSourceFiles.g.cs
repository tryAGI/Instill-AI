#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Search single-source-of-truth files<br/>
        /// Searches the single-source-of-truth files of a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="fileUids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SearchSourceFilesResponse> SearchSourceFilesAsync(
            string namespaceId,
            global::System.Collections.Generic.IList<string>? fileUids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}