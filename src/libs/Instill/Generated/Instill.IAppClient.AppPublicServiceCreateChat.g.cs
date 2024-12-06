#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Create a chat<br/>
        /// Creates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateChatResponse> AppPublicServiceCreateChatAsync(
            string namespaceId,
            global::Instill.CreateChatBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a chat<br/>
        /// Creates a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatDisplayName"></param>
        /// <param name="aiAgentSettings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateChatResponse> AppPublicServiceCreateChatAsync(
            string namespaceId,
            string? chatDisplayName = default,
            global::Instill.AIAgentSettings? aiAgentSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}