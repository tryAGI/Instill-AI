#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List chats<br/>
        /// Returns a paginated list of conversations.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="ifAll"></param>
        /// <param name="chatUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListChatsResponse> AppPublicServiceListChatsAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            bool? ifAll = default,
            string? chatUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}