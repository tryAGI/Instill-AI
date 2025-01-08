#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Create a table<br/>
        /// Creates a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateTableResponse> AppPublicServiceCreateTableAsync(
            string namespaceId,
            global::Instill.Table request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a table<br/>
        /// Creates a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// The ID of the table.
        /// </param>
        /// <param name="title">
        /// The title of the table.
        /// </param>
        /// <param name="description">
        /// A description of the table.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the table.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.CreateTableResponse> AppPublicServiceCreateTableAsync(
            string namespaceId,
            string id,
            string title,
            string? description = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}