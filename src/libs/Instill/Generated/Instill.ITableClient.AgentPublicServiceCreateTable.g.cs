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
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateTableResponse> AgentPublicServiceCreateTableAsync(
            string namespaceId,
            global::Instill.Table request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a table<br/>
        /// Creates a table.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="title">
        /// The title of the table.<br/>
        /// If the table is in draft mode, the title is optional.<br/>
        /// If the table is not in draft mode, the title is required.
        /// </param>
        /// <param name="description">
        /// A description of the table.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the table.
        /// </param>
        /// <param name="agentConfig">
        /// The configuration for the agent.
        /// </param>
        /// <param name="draftMode">
        /// Whether to enable draft mode for the table.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateTableResponse> AgentPublicServiceCreateTableAsync(
            string namespaceId,
            global::Instill.TableAgentConfig agentConfig,
            string? title = default,
            string? description = default,
            object? metadata = default,
            bool? draftMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}