#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Create a table from a table template<br/>
        /// Creates a table from a table template.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateTableFromTemplateResponse> AgentPublicServiceCreateTableFromTemplateAsync(
            string namespaceId,
            global::Instill.CreateTableFromTemplateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a table from a table template<br/>
        /// Creates a table from a table template.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="table">
        /// The table resource to create.
        /// </param>
        /// <param name="templateNamespaceId">
        /// The ID of the table namespace to create the table from.
        /// </param>
        /// <param name="templateTableUid">
        /// The ID of the table to create the table from.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateTableFromTemplateResponse> AgentPublicServiceCreateTableFromTemplateAsync(
            string namespaceId,
            global::Instill.Table table,
            string templateNamespaceId,
            string templateTableUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}