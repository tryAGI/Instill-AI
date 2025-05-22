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
        /// <param name="tableTemplateUid">
        /// The UID of the table template to create the table from.
        /// </param>
        /// <param name="title">
        /// The title of the table.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateTableFromTemplateResponse> AgentPublicServiceCreateTableFromTemplateAsync(
            string namespaceId,
            string tableTemplateUid,
            string title,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}