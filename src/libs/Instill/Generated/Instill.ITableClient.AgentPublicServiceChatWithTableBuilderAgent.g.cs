#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Chat with table builder agent<br/>
        /// Chat with the table builder agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.AgentPublicServiceChatWithTableBuilderAgentResponse> AgentPublicServiceChatWithTableBuilderAgentAsync(
            string namespaceId,
            string tableUid,
            global::Instill.ChatWithTableBuilderAgentBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat with table builder agent<br/>
        /// Chat with the table builder agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.AgentPublicServiceChatWithTableBuilderAgentResponse> AgentPublicServiceChatWithTableBuilderAgentAsync(
            string namespaceId,
            string tableUid,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}