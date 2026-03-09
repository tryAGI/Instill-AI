#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get a user<br/>
        /// Returns the details of a user by their ID.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetUserResponse> MgmtPublicServiceGetUserAsync(
            string name,
            global::Instill.MgmtPublicServiceGetUserView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}