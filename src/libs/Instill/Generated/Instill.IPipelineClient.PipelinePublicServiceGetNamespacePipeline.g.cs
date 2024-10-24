#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Get a pipeline<br/>
        /// Returns the details of a pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespacePipelineResponse> PipelinePublicServiceGetNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.PipelinePublicServiceGetNamespacePipelineView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}