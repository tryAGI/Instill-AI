#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Watch the state of a model version<br/>
        /// Returns the state of a model. The model resource allocation and scaling<br/>
        /// actions take some time, during which a model will be in various state. This<br/>
        /// endpoint allows clients to track the state.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.WatchNamespaceModelResponse> ModelPublicServiceWatchNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}