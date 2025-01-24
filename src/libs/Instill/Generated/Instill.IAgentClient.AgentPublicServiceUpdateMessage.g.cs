#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Update a message<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="messageUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateMessageResponse> AgentPublicServiceUpdateMessageAsync(
            string namespaceId,
            string chatUid,
            string messageUid,
            global::Instill.UpdateMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a message<br/>
        /// Updates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="messageUid"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateMessageResponse> AgentPublicServiceUpdateMessageAsync(
            string namespaceId,
            string chatUid,
            string messageUid,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}