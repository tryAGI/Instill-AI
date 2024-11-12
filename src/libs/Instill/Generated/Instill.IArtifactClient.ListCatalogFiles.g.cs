#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// List catalog files<br/>
        /// Returns a paginated list of catalog files.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="filterFileUids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListCatalogFilesResponse> ListCatalogFilesAsync(
            string namespaceId,
            string catalogId,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<string>? filterFileUids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}