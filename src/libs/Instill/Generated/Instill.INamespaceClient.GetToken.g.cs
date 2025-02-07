#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get an API token<br/>
        /// Returns the details of an API token.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetTokenResponse> GetTokenAsync(
            string tokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}