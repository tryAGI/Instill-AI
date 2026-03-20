#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Update a secret<br/>
        /// Udpates a secret, accessing it by its resource name, which is defined by<br/>
        /// In REST requests, only the supplied secret fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateNamespaceSecretResponse> PipelinePublicServiceUpdateNamespaceSecretAsync(
            string secretName,

            global::Instill.PipelinePublicServiceUpdateNamespaceSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a secret<br/>
        /// Udpates a secret, accessing it by its resource name, which is defined by<br/>
        /// In REST requests, only the supplied secret fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="secretName"></param>
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
        global::System.Threading.Tasks.Task<global::Instill.UpdateNamespaceSecretResponse> PipelinePublicServiceUpdateNamespaceSecretAsync(
            string secretName,
            string displayName,
            string? slug = default,
            string? description = default,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}