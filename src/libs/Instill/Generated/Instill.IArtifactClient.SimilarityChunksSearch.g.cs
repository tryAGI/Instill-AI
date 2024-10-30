#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Retrieve similar chunks<br/>
        /// Returns the similar chunks.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            global::Instill.SimilarityChunksSearchBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve similar chunks<br/>
        /// Returns the similar chunks.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="textPrompt"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            string? instillRequesterUid = default,
            string? textPrompt = default,
            long? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}