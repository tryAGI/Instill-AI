#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Delete a file<br/>
        /// Deletes a file.
        /// </summary>
        /// <param name="fileUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.DeleteCatalogFileResponse> DeleteCatalogFileAsync(
            string fileUid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}