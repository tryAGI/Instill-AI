#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string namespaceId,
            global::Instill.Secret request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a secret<br/>
        /// Creates a new secret under the parenthood of an namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// Secret resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="value">
        /// The value of the secret, which is input-only and will never be returned in API responses.
        /// </param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateNamespaceSecretResponse> PipelinePublicServiceCreateNamespaceSecretAsync(
            string namespaceId,
            string? id = default,
            string? value = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}