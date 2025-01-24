#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Update column definitions<br/>
        /// Updates column definitions for a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateColumnDefinitionsResponse> AgentPublicServiceUpdateColumnDefinitionsAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update column definitions<br/>
        /// Updates column definitions for a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateColumnDefinitionsResponse> AgentPublicServiceUpdateColumnDefinitionsAsync(
            string namespaceId,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}