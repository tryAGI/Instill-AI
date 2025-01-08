#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Update rows<br/>
        /// Updates multiple rows in a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateRowsResponse> AppPublicServiceUpdateRowsAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.IList<global::Instill.Row> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}