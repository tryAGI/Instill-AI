#nullable enable

namespace Instill
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::Instill.ProcessCatalogFilesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="fileUids">
        /// The file uid.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::System.Collections.Generic.IList<string> fileUids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}