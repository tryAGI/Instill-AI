#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Delete row<br/>
        /// Deletes a row from a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="rowUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteRowAsync(
            string namespaceId,
            string tableUid,
            string rowUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}