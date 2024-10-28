#nullable enable

namespace Instill
{
    public partial interface Ix__ArtifactClient
    {
        /// <summary>
        /// Ask a question<br/>
        /// Asks a question.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            global::Instill.QuestionAnsweringBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ask a question<br/>
        /// Asks a question.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="question"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.QuestionAnsweringResponse> QuestionAnsweringAsync(
            string namespaceId,
            string catalogId,
            string? instillRequesterUid = default,
            string? question = default,
            int? topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}