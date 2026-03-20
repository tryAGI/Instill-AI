#nullable enable

namespace Instill
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// Get an integration<br/>
        /// Returns the details of an integration.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.MgmtV1betaGetIntegrationResponse> MgmtPublicServiceGetIntegrationAsync(
            string integrationId,
            global::Instill.MgmtPublicServiceGetIntegrationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}