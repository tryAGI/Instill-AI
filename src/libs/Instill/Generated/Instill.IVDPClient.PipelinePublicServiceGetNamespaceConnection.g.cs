#nullable enable

namespace Instill
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Get a namespace connection<br/>
        /// Returns the details of a connection.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="connectionId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceConnectionResponse> PipelinePublicServiceGetNamespaceConnectionAsync(
            string namespaceId,
            string connectionId,
            global::Instill.PipelinePublicServiceGetNamespaceConnectionView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}