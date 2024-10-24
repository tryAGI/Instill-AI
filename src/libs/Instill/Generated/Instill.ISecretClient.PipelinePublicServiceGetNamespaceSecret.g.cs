#nullable enable

namespace Instill
{
    public partial interface ISecretClient
    {
        /// <summary>
        /// Get a secret<br/>
        /// Returns the details of an namespace-owned secret by its resource name,<br/>
        /// which is defined by the parent namespace and the ID of the secret.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="secretId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceSecretResponse> PipelinePublicServiceGetNamespaceSecretAsync(
            string namespaceId,
            string secretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}