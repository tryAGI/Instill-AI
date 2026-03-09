#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update a chunk<br/>
        /// Updates a chunk.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateChunkResponse> ArtifactPublicServiceUpdateChunkAsync(
            string name,

            global::Instill.UpdateChunkBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a chunk<br/>
        /// Updates a chunk.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="retrievable"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateChunkResponse> ArtifactPublicServiceUpdateChunkAsync(
            string name,
            bool retrievable,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}