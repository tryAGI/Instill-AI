#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Trigger a pipeline asynchronously<br/>
        /// Triggers the execution of a pipeline asynchronously, i.e., the result<br/>
        /// contains the necessary information to access the result and status of the<br/>
        /// operation. This method is intended for cases that require long-running<br/>
        /// workloads.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.<br/>
        /// For more information, see [Run<br/>
        /// NamespacePipeline](https://instill-ai.dev/docs/pipeline/run-pipeline).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.TriggerAsyncNamespacePipelineBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger a pipeline asynchronously<br/>
        /// Triggers the execution of a pipeline asynchronously, i.e., the result<br/>
        /// contains the necessary information to access the result and status of the<br/>
        /// operation. This method is intended for cases that require long-running<br/>
        /// workloads.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.<br/>
        /// For more information, see [Run<br/>
        /// NamespacePipeline](https://instill-ai.dev/docs/pipeline/run-pipeline).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}