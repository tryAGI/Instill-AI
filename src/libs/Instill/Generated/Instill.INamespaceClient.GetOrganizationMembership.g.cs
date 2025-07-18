#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get an organization membership<br/>
        /// Returns the details of a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetOrganizationMembershipResponse> GetOrganizationMembershipAsync(
            string organizationId,
            string userId,
            global::Instill.GetOrganizationMembershipView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}