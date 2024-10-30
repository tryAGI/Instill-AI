#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List namespace models<br/>
        /// Returns a paginated list of models.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="showDeleted"></param>
        /// <param name="filter"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListNamespaceModelsResponse> ModelPublicServiceListNamespaceModelsAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.ModelPublicServiceListNamespaceModelsView? view = default,
            bool? showDeleted = default,
            string? filter = default,
            global::Instill.ModelPublicServiceListNamespaceModelsVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}