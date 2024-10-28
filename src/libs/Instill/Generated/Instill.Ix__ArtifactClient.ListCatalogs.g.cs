#nullable enable

namespace Instill
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Get all catalogs info<br/>
        /// Returns a paginated list of catalogs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListCatalogsResponse> ListCatalogsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}