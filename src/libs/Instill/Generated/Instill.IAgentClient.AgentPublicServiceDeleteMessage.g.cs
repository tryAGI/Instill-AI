#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete a message<br/>
        /// Deletes a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="messageUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceDeleteMessageAsync(
            string namespaceId,
            string chatUid,
            string messageUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}