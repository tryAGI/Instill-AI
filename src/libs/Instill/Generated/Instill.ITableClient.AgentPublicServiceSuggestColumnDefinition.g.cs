#nullable enable

namespace Instill
{
    public partial interface ITableClient
    {
        /// <summary>
        /// Suggest column definition<br/>
        /// Suggests a column definition based on existing table columns and user input.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SuggestColumnDefinitionResponse> AgentPublicServiceSuggestColumnDefinitionAsync(
            string namespaceId,
            string tableUid,
            global::Instill.SuggestColumnDefinitionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Suggest column definition<br/>
        /// Suggests a column definition based on existing table columns and user input.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="tableUid"></param>
        /// <param name="name">
        /// The name of the column.
        /// </param>
        /// <param name="type">
        /// The type of the column.<br/>
        /// If not provided, the agent will suggest the type.<br/>
        /// If provided, the agent will use this value as the type setting.
        /// </param>
        /// <param name="enableAutomaticComputation">
        /// Whether to enable automatic computation for the column.<br/>
        /// If not provided, the agent will suggest whether to enable it or not.<br/>
        /// If provided, the agent will use this value as the enable_automatic_computation setting.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SuggestColumnDefinitionResponse> AgentPublicServiceSuggestColumnDefinitionAsync(
            string namespaceId,
            string tableUid,
            string name,
            global::Instill.Type? type = default,
            bool? enableAutomaticComputation = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}