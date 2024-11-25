#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete a chat<br/>
        /// Deletes a chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteChatAsync(
            string namespaceId,
            string chatUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}