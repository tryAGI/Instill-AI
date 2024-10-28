#nullable enable

namespace Instill
{
    public partial interface Ix__NamespaceClient
    {
        /// <summary>
        /// List organization memberships<br/>
        /// Returns a paginated list of the user memberships in an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListOrganizationMembershipsResponse> ListOrganizationMembershipsAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}