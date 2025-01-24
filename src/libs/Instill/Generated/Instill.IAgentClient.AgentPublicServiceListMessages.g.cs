#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List messages<br/>
        /// Returns a paginated list of messages.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="ifAll"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListMessagesResponse> AgentPublicServiceListMessagesAsync(
            string namespaceId,
            string chatUid,
            int? pageSize = default,
            string? pageToken = default,
            bool? ifAll = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}