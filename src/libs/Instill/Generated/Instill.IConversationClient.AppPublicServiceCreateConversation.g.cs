#nullable enable

namespace Instill
{
    public partial interface IConversationClient
    {
        /// <summary>
        /// Create a Conversation
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.CreateConversationResponse> AppPublicServiceCreateConversationAsync(
            string namespaceId,
            string appId,
            global::Instill.AppPublicServiceCreateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Conversation
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