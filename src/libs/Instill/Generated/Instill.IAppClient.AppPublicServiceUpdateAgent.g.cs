#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Update an agent<br/>
        /// Updates the information of an agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="agentUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateAgentResponse> AppPublicServiceUpdateAgentAsync(
            string namespaceId,
            string agentUid,
            global::Instill.UpdateAgentBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an agent<br/>
        /// Updates the information of an agent.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="agentUid"></param>
        /// <param name="description">
        /// The agent description.
        /// </param>
        /// <param name="tags">
        /// The agent tags.
        /// </param>
        /// <param name="aiAgentApp">
        /// The agent metadata.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateAgentResponse> AppPublicServiceUpdateAgentAsync(
            string namespaceId,
            string agentUid,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Instill.AIAgentAppMetadata? aiAgentApp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}