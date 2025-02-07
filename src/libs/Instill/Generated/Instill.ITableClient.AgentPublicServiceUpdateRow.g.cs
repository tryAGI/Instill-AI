#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Update row<br/>
        /// Updates a row in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateRowResponse> AgentPublicServiceUpdateRowAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            global::Instill.UpdateRowBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update row<br/>
        /// Updates a row in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="row">
        /// The new row data.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateRowResponse> AgentPublicServiceUpdateRowAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            global::Instill.Row? row = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}