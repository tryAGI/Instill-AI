#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// Create a chat<br/>
        /// Creates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateChatResponse> AgentPublicServiceCreateChatAsync(
            string namespaceId,
            global::Instill.CreateChatBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a chat<br/>
        /// Creates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatDisplayName"></param>
        /// <param name="agentConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateChatResponse> AgentPublicServiceCreateChatAsync(
            string namespaceId,
            string? chatDisplayName = default,
            global::Instill.AgentConfig? agentConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}