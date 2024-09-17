#nullable enable

namespace Instill
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Update a catalog info
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogResponse> UpdateCatalogAsync(
            string namespaceId,
            string catalogId,
            global::Instill.UpdateCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a catalog info
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogResponse> UpdateCatalogAsync(
            string namespaceId,
            string catalogId,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}