#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete an agent<br/>
        /// Deletes an agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="agentUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteAgentAsync(
            string namespaceId,
            string agentUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}