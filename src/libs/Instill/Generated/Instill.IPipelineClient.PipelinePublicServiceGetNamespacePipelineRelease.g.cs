#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Get a pipeline release<br/>
        /// Gets the details of a pipeline release, where the pipeline is identified<br/>
        /// by its resource name, formed by its parent namespace and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetNamespacePipelineReleaseResponse> PipelinePublicServiceGetNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::Instill.PipelinePublicServiceGetNamespacePipelineReleaseView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}