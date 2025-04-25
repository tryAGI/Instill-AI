#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Chat with agent<br/>
        /// Chat with the agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.AgentPublicServiceChatWithAgentResponse> AgentPublicServiceChatWithAgentAsync(
            string namespaceId,
            string chatUid,
            global::Instill.ChatWithAgentBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat with agent<br/>
        /// Chat with the agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="message"></param>
        /// <param name="fileUids"></param>
        /// <param name="enableWebSearch">
        /// Whether to enable web search for the chat.
        /// </param>
        /// <param name="objectUids"></param>
        /// <param name="context">
        /// The context for the agent.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.AgentPublicServiceChatWithAgentResponse> AgentPublicServiceChatWithAgentAsync(
            string namespaceId,
            string chatUid,
            string message,
            global::System.Collections.Generic.IList<string>? fileUids = default,
            bool? enableWebSearch = default,
            global::System.Collections.Generic.IList<string>? objectUids = default,
            global::Instill.ChatWithAgentRequestContext? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}