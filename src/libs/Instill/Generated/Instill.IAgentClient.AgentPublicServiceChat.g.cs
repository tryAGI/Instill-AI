#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Chat<br/>
        /// Chat sends a message asynchronously and streams back the response.<br/>
        /// This method is intended for real-time conversation with a chatbot<br/>
        /// and the response needs to be processed incrementally.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ChatResponse> AgentPublicServiceChatAsync(
            string namespaceId,
            string chatUid,
            global::Instill.AgentPublicServiceChatBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat<br/>
        /// Chat sends a message asynchronously and streams back the response.<br/>
        /// This method is intended for real-time conversation with a chatbot<br/>
        /// and the response needs to be processed incrementally.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="message"></param>
        /// <param name="fileUids"></param>
        /// <param name="enableWebSearch">
        /// Whether to enable web search for the chat.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ChatResponse> AgentPublicServiceChatAsync(
            string namespaceId,
            string chatUid,
            string message,
            global::System.Collections.Generic.IList<string>? fileUids = default,
            bool? enableWebSearch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}