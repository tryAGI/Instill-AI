#nullable enable

namespace Instill
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// Restart Playground Conversation<br/>
        /// create a new conversation and use the auth user uid as creator uid and auto<br/>
        /// generate a new conversation id on the behalf of auth user.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.RestartPlaygroundConversationResponse> AppPublicServiceRestartPlaygroundConversationAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}