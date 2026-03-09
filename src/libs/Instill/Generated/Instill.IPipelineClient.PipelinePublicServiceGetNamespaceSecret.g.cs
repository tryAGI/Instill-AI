#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Get a secret<br/>
        /// Returns the details of an namespace-owned secret by its resource name,<br/>
        /// which is defined by the parent namespace and the ID of the secret.
        /// </summary>
        /// <param name="name5"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceSecretResponse> PipelinePublicServiceGetNamespaceSecretAsync(
            string name5,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}