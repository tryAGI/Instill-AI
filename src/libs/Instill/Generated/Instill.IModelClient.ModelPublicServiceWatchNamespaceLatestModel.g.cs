#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Watch the state of the latest model version<br/>
        /// Returns the state of the latest model version. The model resource<br/>
        /// allocation and scaling actions take some time, during which a model will be<br/>
        /// in various state. This endpoint allows clients to track the state.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.WatchNamespaceLatestModelResponse> ModelPublicServiceWatchNamespaceLatestModelAsync(
            string namespaceId,
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}