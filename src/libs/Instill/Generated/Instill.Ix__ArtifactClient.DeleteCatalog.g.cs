#nullable enable

namespace Instill
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Delete a catalog<br/>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.DeleteCatalogResponse> DeleteCatalogAsync(
            string namespaceId,
            string catalogId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}