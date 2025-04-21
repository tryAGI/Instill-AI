#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Unlock cell<br/>
        /// Unlocks a cell in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="cellUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UnlockCellResponse> AgentPublicServiceUnlockCellAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            string cellUid,
            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlock cell<br/>
        /// Unlocks a cell in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="cellUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UnlockCellResponse> AgentPublicServiceUnlockCellAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            string cellUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}