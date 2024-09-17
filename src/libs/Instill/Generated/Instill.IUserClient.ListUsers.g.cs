#nullable enable

namespace Instill
{
    public partial interface IUserClient
    {
        /// <summary>
        /// List users<br/>
        /// Returns a paginated list of users.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListUsersResponse> ListUsersAsync(
            int pageSize = default,
            string? pageToken = default,
            global::Instill.ListUsersView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}