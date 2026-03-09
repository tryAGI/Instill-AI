#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get a knowledge base<br/>
        /// Returns the details of a knowledge base.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetKnowledgeBaseResponse> ArtifactPublicServiceGetKnowledgeBaseAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}