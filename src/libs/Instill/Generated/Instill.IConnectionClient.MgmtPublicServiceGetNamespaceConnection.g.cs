#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Get a namespace connection<br/>
        /// Returns the details of a connection.
        /// </summary>
        /// <param name="name2"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceConnectionResponse> MgmtPublicServiceGetNamespaceConnectionAsync(
            string name2,
            global::Instill.MgmtPublicServiceGetNamespaceConnectionView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}