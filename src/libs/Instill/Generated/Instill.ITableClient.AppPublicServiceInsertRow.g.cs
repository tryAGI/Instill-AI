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
            global::Instill.Row request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert row<br/>
        /// Inserts a row into a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="cells">
        /// Map of column names to their cell values.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.InsertRowResponse> AppPublicServiceInsertRowAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.Dictionary<string, global::Instill.Cell> cells,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}