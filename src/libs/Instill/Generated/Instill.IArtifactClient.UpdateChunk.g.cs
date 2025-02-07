#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            global::Instill.UpdateChunkBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update catalog chunk<br/>
        /// Updates a catalog chunk.
        /// </summary>
        /// <param name="chunkUid"></param>
        /// <param name="retrievable"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateChunkResponse> UpdateChunkAsync(
            string chunkUid,
            bool? retrievable = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}