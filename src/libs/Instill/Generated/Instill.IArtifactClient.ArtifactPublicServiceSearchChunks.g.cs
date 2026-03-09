#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Search chunks<br/>
        /// Returns the top-K most similar chunks to a text prompt.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.SearchChunksResponse> ArtifactPublicServiceSearchChunksAsync(
            string parent,

            global::Instill.SearchChunksBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search chunks<br/>
        /// Returns the top-K most similar chunks to a text prompt.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="knowledgeBase"></param>
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
        /// File media type.
        /// </param>
        /// <param name="files"></param>
        /// <param name="tags">
        /// Tags to filter by. When multiple tags are provided, OR logic is applied.<br/>
        /// Note: File filter takes precedence over tags, as tags apply to files.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.SearchChunksResponse> ArtifactPublicServiceSearchChunksAsync(
            string parent,
            string textPrompt,
            string? instillRequesterUid = default,
            string? knowledgeBase = default,
            long? topK = default,
            global::Instill.ChunkType? type = default,
            global::Instill.FileMediaType? fileMediaType = default,
            global::System.Collections.Generic.IList<string>? files = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}