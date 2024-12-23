#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Update a chat<br/>
        /// Updates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateChatResponse> AppPublicServiceUpdateChatAsync(
            string namespaceId,
            string chatUid,
            global::Instill.UpdateChatBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a chat<br/>
        /// Updates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="chatDisplayName"></param>
        /// <param name="aiAgentSettings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateChatResponse> AppPublicServiceUpdateChatAsync(
            string namespaceId,
            string chatUid,
            string? chatDisplayName = default,
            global::Instill.AIAgentSettings? aiAgentSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}