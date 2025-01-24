#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Get table<br/>
        /// Gets a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetTableResponse> AgentPublicServiceGetTableAsync(
            string namespaceId,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}