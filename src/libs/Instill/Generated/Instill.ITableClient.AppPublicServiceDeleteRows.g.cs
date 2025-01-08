#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Delete rows<br/>
        /// Deletes multiple rows from a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteRowsAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.IList<string> rowUids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}