#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete a message<br/>
        /// Deletes a message.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chatUid"></param>
        /// <param name="messageUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteMessageAsync(
            string namespaceId,
            string chatUid,
            string messageUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}