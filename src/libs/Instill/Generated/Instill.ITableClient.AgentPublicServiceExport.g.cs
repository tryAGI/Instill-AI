#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Export table<br/>
        /// Exports table data.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ExportResponse> AgentPublicServiceExportAsync(
            string namespaceId,
            string tableUid,
            string type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}