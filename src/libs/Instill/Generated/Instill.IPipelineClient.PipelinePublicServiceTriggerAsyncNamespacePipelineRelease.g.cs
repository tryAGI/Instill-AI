#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Trigger a pipeline release asynchronously<br/>
        /// Triggers the asynchronous execution of of a pipeline. While the trigger<br/>
        /// endpoint (where the release version isn't specified) triggers the pipeline<br/>
        /// at its latest release, this method allows the client to specified any<br/>
        /// committed release.<br/>
        /// The pipeline is identified by its resource name, formed by its parent<br/>
        /// namespace and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::Instill.TriggerAsyncNamespacePipelineReleaseBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger a pipeline release asynchronously<br/>
        /// Triggers the asynchronous execution of of a pipeline. While the trigger<br/>
        /// endpoint (where the release version isn't specified) triggers the pipeline<br/>
        /// at its latest release, this method allows the client to specified any<br/>
        /// committed release.<br/>
        /// The pipeline is identified by its resource name, formed by its parent<br/>
        /// namespace and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
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
        global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}