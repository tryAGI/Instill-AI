#nullable enable

namespace Instill
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// Delete a connection<br/>
        /// Deletes a connection.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="connectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeleteNamespaceConnectionAsync(
            string namespaceId,
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}