#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Update column definitions<br/>
        /// Updates column definitions for a table. When updating the column<br/>
        /// definitions, if the column's agent instructions are updated, the existing<br/>
        /// cells in that column will be cleared and recomputed. This ensures that all<br/>
        /// data reflects the latest instructions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateColumnDefinitionsResponse> AgentPublicServiceUpdateColumnDefinitionsAsync(
            string namespaceId,
            string tableUid,
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update column definitions<br/>
        /// Updates column definitions for a table. When updating the column<br/>
        /// definitions, if the column's agent instructions are updated, the existing<br/>
        /// cells in that column will be cleared and recomputed. This ensures that all<br/>
        /// data reflects the latest instructions.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateColumnDefinitionsResponse> AgentPublicServiceUpdateColumnDefinitionsAsync(
            string namespaceId,
            string tableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}