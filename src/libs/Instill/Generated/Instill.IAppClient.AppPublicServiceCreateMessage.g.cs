#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Create a message<br/>
        /// Creates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateMessageResponse> AppPublicServiceCreateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::Instill.CreateMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a message<br/>
        /// Creates a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateMessageResponse> AppPublicServiceCreateMessageAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string content,
            string role,
            global::Instill.MessageType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}