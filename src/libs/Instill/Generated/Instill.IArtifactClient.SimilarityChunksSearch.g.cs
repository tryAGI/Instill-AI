#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Retrieve similar chunks<br/>
        /// Returns the top-K most similar chunks to a text prompt.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            global::Instill.SimilarityChunksSearchBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve similar chunks<br/>
        /// Returns the top-K most similar chunks to a text prompt.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="textPrompt">
        /// Text prompt to look for similarities.
        /// </param>
        /// <param name="topK">
        /// Top K. Default value: 5.
        /// </param>
        /// <param name="type">
        /// Chunk type.
        /// </param>
        /// <param name="fileMediaType">
        /// File type.
        /// </param>
        /// <param name="fileUids">
        /// File UIDs. When this field is provided, the response will return only<br/>
        /// chunks that belong to the specified file UIDs.
        /// </param>
        /// <param name="tags">
        /// Tags to filter by. When multiple tags are provided, OR logic is applied.<br/>
        /// Note: File UID filter takes precedence over tags, as tags apply to files.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            string textPrompt,
            string? instillRequesterUid = default,
            long? topK = default,
            global::Instill.ChunkType? type = default,
            global::Instill.FileMediaType? fileMediaType = default,
            global::System.Collections.Generic.IList<string>? fileUids = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}