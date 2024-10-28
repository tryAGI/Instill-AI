#nullable enable

namespace Instill
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Create a conversation<br/>
        /// Creates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.CreateConversationResponse> AppPublicServiceCreateConversationAsync(
            string namespaceId,
            string appId,
            global::Instill.CreateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a conversation<br/>
        /// Creates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.CreateConversationResponse> AppPublicServiceCreateConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}