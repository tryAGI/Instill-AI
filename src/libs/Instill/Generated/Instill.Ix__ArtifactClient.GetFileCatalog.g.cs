#nullable enable

namespace Instill
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Get file catalog<br/>
        /// Get the catalog file.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileId"></param>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetFileCatalogResponse> GetFileCatalogAsync(
            string namespaceId,
            string catalogId,
            string? fileId = default,
            string? fileUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}