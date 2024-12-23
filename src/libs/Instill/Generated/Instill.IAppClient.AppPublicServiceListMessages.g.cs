#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List messages<br/>
        /// Returns a paginated list of messages.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="latestK"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="includeSystemMessages"></param>
        /// <param name="ifAll"></param>
        /// <param name="messageUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListMessagesResponse> AppPublicServiceListMessagesAsync(
            string namespaceId,
            string appId,
            string conversationId,
            int? latestK = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeSystemMessages = default,
            bool? ifAll = default,
            string? messageUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}