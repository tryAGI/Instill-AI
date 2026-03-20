#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an API token<br/>
        /// Deletes an API token.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> MgmtPublicServiceDeleteTokenAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}