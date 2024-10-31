#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Restart Playground Conversation<br/>
        /// Creates a new conversation and uses the auth user UID as creator UID and<br/>
        /// auto-generates a new conversation ID on the behalf of auth user.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.RestartPlaygroundConversationResponse> AppPublicServiceRestartPlaygroundConversationAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}