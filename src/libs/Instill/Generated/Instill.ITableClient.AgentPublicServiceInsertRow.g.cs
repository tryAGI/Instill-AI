#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Insert row<br/>
        /// Inserts a row into a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.InsertRowResponse> AgentPublicServiceInsertRowAsync(
            string namespaceId,
            string tableUid,
            global::Instill.InsertRowBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert row<br/>
        /// Inserts a row into a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="row">
        /// The rows to insert.
        /// </param>
        /// <param name="beforeRowUid">
        /// The unique identifier of the row to insert before.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.InsertRowResponse> AgentPublicServiceInsertRowAsync(
            string namespaceId,
            string tableUid,
            global::Instill.Row? row = default,
            string? beforeRowUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}