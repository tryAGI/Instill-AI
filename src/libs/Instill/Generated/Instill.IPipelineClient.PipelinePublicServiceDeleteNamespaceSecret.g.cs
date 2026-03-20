#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {

        /// <summary>
        /// Delete a secret<br/>
        /// Deletes a secret, accesing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the secret.
        /// </summary>
        /// <param name="name4"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeleteNamespaceSecretAsync(
            string name4,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}