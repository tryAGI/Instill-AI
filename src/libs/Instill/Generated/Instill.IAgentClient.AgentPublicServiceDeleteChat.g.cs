#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Delete a chat<br/>
        /// Deletes a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceDeleteChatAsync(
            string namespaceId,
            string chatUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}