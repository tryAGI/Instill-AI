#nullable enable

namespace Instill
{
    public partial interface IFolderClient
    {
        /// <summary>
        /// Get folder<br/>
        /// Gets a folder.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="folderUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetFolderResponse> AgentPublicServiceGetFolderAsync(
            string namespaceId,
            string folderUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}