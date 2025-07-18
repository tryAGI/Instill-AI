#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Clone a pipeline<br/>
        /// Clones a pipeline owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceCloneNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.CloneNamespacePipelineBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone a pipeline<br/>
        /// Clones a pipeline owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="targetNamespaceId">
        /// Target Namespace ID.
        /// </param>
        /// <param name="targetPipelineId">
        /// Target Pipeline ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceCloneNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            string targetNamespaceId,
            string targetPipelineId,
            string? description = default,
            global::Instill.Sharing? sharing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}