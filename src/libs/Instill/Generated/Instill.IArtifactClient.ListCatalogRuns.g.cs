#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// List Catalog Runs<br/>
        /// Returns a paginated list of catalog runs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListCatalogRunsResponse> ListCatalogRunsAsync(
            string namespaceId,
            string catalogId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}