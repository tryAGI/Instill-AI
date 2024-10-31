#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// List catalog chunks<br/>
        /// Returns a paginated list of catalog chunks.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="fileUid"></param>
        /// <param name="chunkUids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListChunksResponse> ListChunksAsync(
            string namespaceId,
            string catalogId,
            string? fileUid = default,
            global::System.Collections.Generic.IList<string>? chunkUids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}