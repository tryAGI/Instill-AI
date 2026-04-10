#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Get a namespace connection<br/>
        /// Returns the details of a connection.
        /// </summary>
        /// <param name="name2"></param>
        /// <param name="view"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceConnectionResponse> MgmtPublicServiceGetNamespaceConnectionAsync(
            string name2,
            global::Instill.MgmtPublicServiceGetNamespaceConnectionView? view = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}