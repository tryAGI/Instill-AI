#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Search catalog chunks<br/>
        /// Returns a paginated list of catalog chunks based on search criteria.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="chunkUids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SearchChunksResponse> SearchChunksAsync(
            string namespaceId,
            global::System.Collections.Generic.IList<string> chunkUids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}