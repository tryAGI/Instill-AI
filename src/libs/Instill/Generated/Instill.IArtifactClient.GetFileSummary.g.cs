#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get summary from a catalog file<br/>
        /// Gets summary from a catalog file
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetFileSummaryResponse> GetFileSummaryAsync(
            string namespaceId,
            string catalogId,
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}