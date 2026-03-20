#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {

        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the<br/>
        /// response. This method is intended for real-time inference when low latency<br/>
        /// is of concern and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instillRequesterUid"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.PipelinePublicServiceTriggerPipelineWithStreamResponse> PipelinePublicServiceTriggerPipelineWithStreamAsync(
            string name,

            global::Instill.TriggerPipelineWithStreamBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the<br/>
        /// response. This method is intended for real-time inference when low latency<br/>
        /// is of concern and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent<br/>
        /// namespace and ID of the pipeline.
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
        global::System.Threading.Tasks.Task<global::Instill.PipelinePublicServiceTriggerPipelineWithStreamResponse> PipelinePublicServiceTriggerPipelineWithStreamAsync(
            string name,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}