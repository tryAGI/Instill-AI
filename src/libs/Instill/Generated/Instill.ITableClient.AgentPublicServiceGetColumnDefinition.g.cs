#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Get column definition<br/>
        /// Gets a column definition for a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="columnUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetColumnDefinitionResponse> AgentPublicServiceGetColumnDefinitionAsync(
            string namespaceId,
            string tableUid,
            string columnUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}