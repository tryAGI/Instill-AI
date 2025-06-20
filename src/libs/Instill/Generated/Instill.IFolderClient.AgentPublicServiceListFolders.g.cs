#nullable enable

namespace Instill
{
    public partial interface IFolderClient
    {
        /// <summary>
        /// List folders<br/>
        /// Returns a list of folders.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListFoldersResponse> AgentPublicServiceListFoldersAsync(
            string namespaceId,
            string? pageToken = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}