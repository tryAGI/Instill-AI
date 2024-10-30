#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of the latest long-running operation from a namespace model<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceLatestModelOperationResponse> ModelPublicServiceGetNamespaceLatestModelOperationAsync(
            string namespaceId,
            string modelId,
            global::Instill.ModelPublicServiceGetNamespaceLatestModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}