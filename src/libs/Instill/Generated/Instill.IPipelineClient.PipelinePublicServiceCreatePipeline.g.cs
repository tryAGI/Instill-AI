#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {

        /// <summary>
        /// Create a new pipeline<br/>
        /// Creates a new pipeline under a namespace.
        /// </summary>
        /// <param name="parent"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreatePipelineResponse> PipelinePublicServiceCreatePipelineAsync(
            string parent,

            global::Instill.Pipeline request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new pipeline<br/>
        /// Creates a new pipeline under a namespace.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug">
        /// Field 4: URL-friendly slug (NO prefix).<br/>
        /// If omitted, server generates from display_name.<br/>
        /// Slug is NOT part of resource identity.
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="recipe">
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format.
        /// </param>
        /// <param name="visibility">
        /// Pipeline visibility.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="metadata">
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </param>
        /// <param name="readme">
        /// README holds the pipeline documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the pipeline is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Pipeline profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreatePipelineResponse> PipelinePublicServiceCreatePipelineAsync(
            string parent,
            string displayName,
            object recipe,
            global::Instill.PipelineVisibility visibility,
            string? slug = default,
            string? description = default,
            string? rawRecipe = default,
            global::Instill.Sharing? sharing = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? metadata = default,
            string? readme = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}