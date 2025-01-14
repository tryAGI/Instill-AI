#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Move row<br/>
        /// Moves a row to a new position in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceMoveRowsAsync(
            string namespaceId,
            string tableUid,
            global::Instill.MoveRowsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move row<br/>
        /// Moves a row to a new position in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUids">
        /// The unique identifiers of the rows to be moved.
        /// </param>
        /// <param name="beforeRowUid">
        /// The unique identifier of the row to move before.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceMoveRowsAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.IList<string> rowUids,
            string? beforeRowUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}