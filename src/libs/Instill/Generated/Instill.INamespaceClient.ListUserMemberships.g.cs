#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// List user memberships<br/>
        /// Returns the memberships of a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListUserMembershipsResponse> ListUserMembershipsAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}