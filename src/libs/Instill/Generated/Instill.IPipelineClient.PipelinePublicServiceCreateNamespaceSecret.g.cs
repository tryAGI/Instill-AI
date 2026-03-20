#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string parent,

            global::Instill.Secret request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="value">
        /// Field 9: The value of the secret, which is input-only and will never be returned in API responses.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string parent,
            string displayName,
            string? slug = default,
            string? description = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}