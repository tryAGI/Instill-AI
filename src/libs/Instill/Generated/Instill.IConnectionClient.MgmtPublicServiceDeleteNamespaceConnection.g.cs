#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Delete a connection<br/>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MgmtPublicServiceDeleteNamespaceConnectionAsync(
            string name1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}