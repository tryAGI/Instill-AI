#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// List chat tables<br/>
        /// Returns a list of tables bound to a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListChatTablesResponse> AgentPublicServiceListChatTablesAsync(
            string namespaceId,
            string chatUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}