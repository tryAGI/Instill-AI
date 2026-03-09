#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get all knowledge bases info<br/>
        /// Returns a paginated list of knowledge bases.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListKnowledgeBasesResponse> ArtifactPublicServiceListKnowledgeBasesAsync(
            string parent,
            int? pageSize = default,
            string? pageToken = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}