#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.DeleteFileResponse> ArtifactPublicServiceDeleteFileAsync(
            string name1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}