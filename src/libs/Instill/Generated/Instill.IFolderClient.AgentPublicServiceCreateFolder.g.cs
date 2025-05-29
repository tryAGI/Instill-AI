#nullable enable

namespace Instill
{
    public partial interface IFolderClient
    {
        /// <summary>
        /// Create folder<br/>
        /// Creates a folder.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateFolderResponse> AgentPublicServiceCreateFolderAsync(
            string namespaceId,
            global::Instill.CreateFolderBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create folder<br/>
        /// Creates a folder.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="folder">
        /// The folder resource to create.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateFolderResponse> AgentPublicServiceCreateFolderAsync(
            string namespaceId,
            global::Instill.Folder folder,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}