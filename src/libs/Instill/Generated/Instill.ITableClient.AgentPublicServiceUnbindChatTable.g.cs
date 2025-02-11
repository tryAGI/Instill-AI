#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Unbind table from chat<br/>
        /// Unbinds a table from a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceUnbindChatTableAsync(
            string namespaceId,
            string chatUid,
            global::Instill.UnbindChatTableBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unbind table from chat<br/>
        /// Unbinds a table from a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="tableUid">
        /// The UID of the table to unbind from the chat.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> AgentPublicServiceUnbindChatTableAsync(
            string namespaceId,
            string chatUid,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}