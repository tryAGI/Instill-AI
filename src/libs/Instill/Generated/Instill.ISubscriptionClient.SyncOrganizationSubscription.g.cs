#nullable enable

namespace Instill
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// Sync the subscription of an organization<br/>
        /// Syncs the subscription of an organization with Stripe.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> SyncOrganizationSubscriptionAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}