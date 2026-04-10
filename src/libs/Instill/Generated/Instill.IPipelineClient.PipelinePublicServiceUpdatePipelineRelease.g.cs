#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Update a pipeline release<br/>
        /// Updates the details of a pipeline release, where the pipeline is<br/>
        /// identified by its resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="releaseName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdatePipelineReleaseResponse> PipelinePublicServiceUpdatePipelineReleaseAsync(
            string releaseName,

            global::Instill.PipelinePublicServiceUpdatePipelineReleaseRequest request,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pipeline release<br/>
        /// Updates the details of a pipeline release, where the pipeline is<br/>
        /// identified by its resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="releaseName"></param>
        /// <param name="id">
        /// Field 2: Release resource ID (used in `name` as the last segment). It must<br/>
        /// be a sematic version vX.Y.Z.
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="description">
        /// Field 6: Release description.
        /// </param>
        /// <param name="metadata">
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </param>
        /// <param name="readme">
        /// README.
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdatePipelineReleaseResponse> PipelinePublicServiceUpdatePipelineReleaseAsync(
            string releaseName,
            string? id = default,
            string? displayName = default,
            string? description = default,
            object? metadata = default,
            string? readme = default,
            string? rawRecipe = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}