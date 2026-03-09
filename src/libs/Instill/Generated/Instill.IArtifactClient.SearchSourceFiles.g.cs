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
        global::System.Threading.Tasks.Task<global::Instill.SearchSourceFilesResponse> SearchSourceFilesAsync(
            string namespaceId,
            global::System.Collections.Generic.IList<string> fileUids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}