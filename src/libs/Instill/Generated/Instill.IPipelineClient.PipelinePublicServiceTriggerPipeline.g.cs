#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Trigger a pipeline<br/>
        /// Triggers the execution of a pipeline synchronously, i.e., the result is<br/>
        /// sent back to the namespace right after the data is processed. This method<br/>
        /// is intended for real-time inference when low latency is of concern.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.<br/>
        /// For more information, see [Run<br/>
        /// Pipeline](https://instill-ai.dev/docs/pipeline/run-pipeline).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerPipelineResponse> PipelinePublicServiceTriggerPipelineAsync(
            string name,

            global::Instill.TriggerPipelineBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger a pipeline<br/>
        /// Triggers the execution of a pipeline synchronously, i.e., the result is<br/>
        /// sent back to the namespace right after the data is processed. This method<br/>
        /// is intended for real-time inference when low latency is of concern.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.<br/>
        /// For more information, see [Run<br/>
        /// Pipeline](https://instill-ai.dev/docs/pipeline/run-pipeline).
        /// </summary>
        /// <param name="name"></param>
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
        global::System.Threading.Tasks.Task<global::Instill.TriggerPipelineResponse> PipelinePublicServiceTriggerPipelineAsync(
            string name,
            global::System.Collections.Generic.IList<object> inputs,
            global::System.Collections.Generic.IList<global::Instill.TriggerData> data,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}