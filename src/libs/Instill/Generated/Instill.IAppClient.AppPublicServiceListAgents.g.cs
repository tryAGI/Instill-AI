#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List all agents info<br/>
        /// Returns a paginated list of agents.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListAgentsResponse> AppPublicServiceListAgentsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}