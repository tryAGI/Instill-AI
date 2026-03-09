#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Delete a knowledge base<br/>
        /// Deletes a knowledge base.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.DeleteKnowledgeBaseResponse> ArtifactPublicServiceDeleteKnowledgeBaseAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}