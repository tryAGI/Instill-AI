#nullable enable

namespace Instill
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// Get the subscription of an organization<br/>
        /// Returns the subscription details of an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetOrganizationSubscriptionResponse> GetOrganizationSubscriptionAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}