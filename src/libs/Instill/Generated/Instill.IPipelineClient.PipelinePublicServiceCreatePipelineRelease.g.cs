#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Create a pipeline release<br/>
        /// Commits the version of a pipeline, identified by its resource name, which<br/>
        /// is formed by the parent namespace and ID of the pipeline.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreatePipelineReleaseResponse> PipelinePublicServiceCreatePipelineReleaseAsync(
            string parent,

            global::Instill.PipelineRelease request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a pipeline release<br/>
        /// Commits the version of a pipeline, identified by its resource name, which<br/>
        /// is formed by the parent namespace and ID of the pipeline.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="parent"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreatePipelineReleaseResponse> PipelinePublicServiceCreatePipelineReleaseAsync(
            string parent,
            string? id = default,
            string? displayName = default,
            string? description = default,
            object? metadata = default,
            string? readme = default,
            string? rawRecipe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}