#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// List tables<br/>
        /// Returns a paginated list of tables.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListTablesResponse> AppPublicServiceListTablesAsync(
            string namespaceId,
            string? pageToken = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}