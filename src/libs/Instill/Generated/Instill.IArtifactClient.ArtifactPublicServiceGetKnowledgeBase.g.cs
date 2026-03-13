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
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetKnowledgeBaseResponse> ArtifactPublicServiceGetKnowledgeBaseAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}