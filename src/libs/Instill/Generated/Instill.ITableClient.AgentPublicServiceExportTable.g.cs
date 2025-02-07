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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ExportTableResponse> AgentPublicServiceExportTableAsync(
            string namespaceId,
            string tableUid,
            global::Instill.ExportTableBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Export table<br/>
        /// Exports table data.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="format">
        /// The format to export the data in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ExportTableResponse> AgentPublicServiceExportTableAsync(
            string namespaceId,
            string tableUid,
            global::Instill.ExportFormat format,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}