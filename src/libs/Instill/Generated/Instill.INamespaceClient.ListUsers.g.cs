#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
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
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListUsersResponse> ListUsersAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.ListUsersView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}