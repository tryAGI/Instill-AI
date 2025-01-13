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
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.InsertRowResponse> AppPublicServiceInsertRowAsync(
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
        /// <param name="afterRowUid">
        /// The unique identifier of the row to insert after.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.InsertRowResponse> AppPublicServiceInsertRowAsync(
            string namespaceId,
            string tableUid,
            global::Instill.Row? row = default,
            string? afterRowUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}