#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Get an integration<br/>
        /// Returns the details of an integration.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetIntegrationResponse> PipelinePublicServiceGetIntegrationAsync(
            string integrationId,
            global::Instill.PipelinePublicServiceGetIntegrationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}