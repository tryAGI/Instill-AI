#nullable enable

namespace Instill
{
    public partial interface IMessageClient
    {
        /// <summary>
        /// Delete a message
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="messageUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}