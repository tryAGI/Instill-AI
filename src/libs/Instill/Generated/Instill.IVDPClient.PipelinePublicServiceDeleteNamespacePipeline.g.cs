#nullable enable

namespace Instill
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Delete a pipeline<br/>
        /// Deletes a pipeline, accesing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated namespace must be<br/>
        /// the parent of the pipeline in order to delete it.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeleteNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}