#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get a user membership<br/>
        /// Returns the details of the relationship between a user and an<br/>
        /// organization. The authenticated must match the membership parent.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetUserMembershipResponse> GetUserMembershipAsync(
            string userId,
            string organizationId,
            global::Instill.GetUserMembershipView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}