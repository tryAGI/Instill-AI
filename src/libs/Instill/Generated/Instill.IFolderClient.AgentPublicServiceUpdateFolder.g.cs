#nullable enable

namespace Instill
{
    public partial interface IFolderClient
    {
        /// <summary>
        /// Update folder<br/>
        /// Updates a folder.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="folderUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateFolderResponse> AgentPublicServiceUpdateFolderAsync(
            string namespaceId,
            string folderUid,
            global::Instill.UpdateFolderBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update folder<br/>
        /// Updates a folder.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="folderUid"></param>
        /// <param name="folder">
        /// The folder fields that will replace the existing ones.
        /// </param>
        /// <param name="updateMask">
        /// The update mask specifies the subset of fields that should be modified.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateFolderResponse> AgentPublicServiceUpdateFolderAsync(
            string namespaceId,
            string folderUid,
            string updateMask,
            global::Instill.Folder? folder = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}