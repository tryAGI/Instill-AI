#nullable enable

namespace Instill
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// List context options<br/>
        /// This is a helper endpoint to list context options for chat.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListContextOptionsResponse> AgentPublicServiceListContextOptionsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}