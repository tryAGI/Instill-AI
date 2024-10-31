#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Update a conversation<br/>
        /// Updates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateConversationResponse> AppPublicServiceUpdateConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::Instill.UpdateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a conversation<br/>
        /// Updates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="newConversationId"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateConversationResponse> AppPublicServiceUpdateConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string? newConversationId = default,
            string? lastUsedCatalogUid = default,
            long? lastUsedTopK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}