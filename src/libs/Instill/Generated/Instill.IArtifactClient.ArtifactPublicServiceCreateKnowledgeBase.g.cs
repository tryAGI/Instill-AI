#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Create a knowledge base<br/>
        /// Creates a knowledge base.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateKnowledgeBaseResponse> ArtifactPublicServiceCreateKnowledgeBaseAsync(
            string parent,

            global::Instill.KnowledgeBase request,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge base<br/>
        /// Creates a knowledge base.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="tags">
        /// The knowledge base tags.
        /// </param>
        /// <param name="type">
        /// The knowledge base type (persistent or ephemeral).<br/>
        /// Default is PERSISTENT if not specified during creation.
        /// </param>
        /// <param name="system">
        /// The resource name of the system configuration.<br/>
        /// Format: `systems/{system}`<br/>
        /// Available systems: "systems/openai", "systems/gemini", or custom systems.<br/>
        /// If not specified, defaults to the default system.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the knowledge base.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateKnowledgeBaseResponse> ArtifactPublicServiceCreateKnowledgeBaseAsync(
            string parent,
            string displayName,
            string? slug = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Instill.KnowledgeBaseType? type = default,
            string? system = default,
            global::Instill.EmbeddingConfig? embeddingConfig = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}