#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ClonePipelineReleaseResponse> PipelinePublicServiceClonePipelineReleaseAsync(
            string name1,

            global::Instill.ClonePipelineReleaseBody request,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="target"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ClonePipelineReleaseResponse> PipelinePublicServiceClonePipelineReleaseAsync(
            string name1,
            string target,
            string? description = default,
            global::Instill.Sharing? sharing = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}