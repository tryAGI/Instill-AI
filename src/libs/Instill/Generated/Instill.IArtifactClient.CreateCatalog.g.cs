#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Create a catalog<br/>
        /// Creates a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            global::Instill.CreateCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a catalog<br/>
        /// Creates a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="name">
        /// The catalog name.
        /// </param>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateCatalogResponse> CreateCatalogAsync(
            string namespaceId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Instill.CatalogType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}