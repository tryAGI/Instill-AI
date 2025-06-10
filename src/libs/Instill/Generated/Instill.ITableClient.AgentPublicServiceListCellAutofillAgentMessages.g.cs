#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// List cell messages<br/>
        /// Lists the internal LLM messages that used to generate the cell value.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="cellUid"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="ifAll"></param>
        /// <param name="returnRawMessages"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListCellAutofillAgentMessagesResponse> AgentPublicServiceListCellAutofillAgentMessagesAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            string cellUid,
            int? pageSize = default,
            string? pageToken = default,
            bool? ifAll = default,
            bool? returnRawMessages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}