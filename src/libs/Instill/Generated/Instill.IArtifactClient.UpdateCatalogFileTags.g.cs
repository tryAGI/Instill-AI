#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update catalog file tags<br/>
        /// Updates the tags associated with a catalog file.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogFileTagsResponse> UpdateCatalogFileTagsAsync(
            string namespaceId,
            string catalogId,
            string fileUid,
            global::Instill.UpdateCatalogFileTagsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update catalog file tags<br/>
        /// Updates the tags associated with a catalog file.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="tags">
        /// Array of tags to associate with the file.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogFileTagsResponse> UpdateCatalogFileTagsAsync(
            string namespaceId,
            string catalogId,
            string fileUid,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}