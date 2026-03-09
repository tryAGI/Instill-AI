#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get an API token<br/>
        /// Returns the details of an API token.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetTokenResponse> MgmtPublicServiceGetTokenAsync(
            string name1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}