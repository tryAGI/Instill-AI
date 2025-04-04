#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Rename a pipeline<br/>
        /// Updates the ID of a pipeline. Since this is an output-only field, a custom<br/>
        /// method is required to modify it.<br/>
        /// The pipeline name will be updated accordingly, as it is  composed by the<br/>
        /// parent namespace and ID of the pipeline (e.g.<br/>
        /// `namespaces/luigi/pipelines/pizza-recipe-generator`).<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenameNamespacePipelineResponse> PipelinePublicServiceRenameNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.RenameNamespacePipelineBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename a pipeline<br/>
        /// Updates the ID of a pipeline. Since this is an output-only field, a custom<br/>
        /// method is required to modify it.<br/>
        /// The pipeline name will be updated accordingly, as it is  composed by the<br/>
        /// parent namespace and ID of the pipeline (e.g.<br/>
        /// `namespaces/luigi/pipelines/pizza-recipe-generator`).<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="newPipelineId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/pipelines/{new_pipeline_id}`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenameNamespacePipelineResponse> PipelinePublicServiceRenameNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            string newPipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}