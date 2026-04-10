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
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenamePipelineResponse> PipelinePublicServiceRenamePipelineAsync(
            string name,

            global::Instill.RenamePipelineBody request,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="name"></param>
        /// <param name="newPipelineId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace}/pipelines/{new_pipeline_id}`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenamePipelineResponse> PipelinePublicServiceRenamePipelineAsync(
            string name,
            string newPipelineId,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}