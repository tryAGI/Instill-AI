#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Move file to another catalog<br/>
        /// Moves a file to another catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.MoveFileToCatalogResponse> MoveFileToCatalogAsync(
            string namespaceId,
            string catalogId,
            global::Instill.MoveFileToCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move file to another catalog<br/>
        /// Moves a file to another catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid">
        /// The file uid.
        /// </param>
        /// <param name="toCatalogId">
        /// The target catalog id.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.MoveFileToCatalogResponse> MoveFileToCatalogAsync(
            string namespaceId,
            string catalogId,
            string fileUid,
            string toCatalogId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}