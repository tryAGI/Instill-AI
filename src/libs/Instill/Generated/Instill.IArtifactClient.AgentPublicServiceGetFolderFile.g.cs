#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get catalog file<br/>
        /// Gets the file of a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="folderUid"></param>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetFolderFileResponse> AgentPublicServiceGetFolderFileAsync(
            string namespaceId,
            string folderUid,
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}