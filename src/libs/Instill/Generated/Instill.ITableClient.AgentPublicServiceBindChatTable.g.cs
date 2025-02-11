#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Bind table to chat<br/>
        /// Binds a table to a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceBindChatTableAsync(
            string namespaceId,
            string chatUid,
            global::Instill.BindChatTableBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Bind table to chat<br/>
        /// Binds a table to a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="tableUid">
        /// The UID of the table to bind to the chat.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceBindChatTableAsync(
            string namespaceId,
            string chatUid,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}