#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Reprocess a file<br/>
        /// Triggers reprocessing of a file with its current configuration.<br/>
        /// This will regenerate embeddings, chunks, and summaries.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ReprocessFileResponse> ArtifactPublicServiceReprocessFileAsync(
            string name,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reprocess a file<br/>
        /// Triggers reprocessing of a file with its current configuration.<br/>
        /// This will regenerate embeddings, chunks, and summaries.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ReprocessFileResponse> ArtifactPublicServiceReprocessFileAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}