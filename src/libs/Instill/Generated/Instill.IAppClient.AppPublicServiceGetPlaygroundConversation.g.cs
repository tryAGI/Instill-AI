#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Get Playground Conversation<br/>
        /// Returns the latest conversation of auth user(e.g. login user and api key user).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetPlaygroundConversationResponse> AppPublicServiceGetPlaygroundConversationAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}