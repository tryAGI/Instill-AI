#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get a model<br/>
        /// Returns the detail of a model, accessing it by the model ID and its parent namespace.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceModelResponse> ModelPublicServiceGetNamespaceModelAsync(
            string namespaceId,
            string modelId,
            global::Instill.ModelPublicServiceGetNamespaceModelView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}