#nullable enable

namespace Instill
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// Get the remaining Instill Credit<br/>
        /// This endpoint returns the remaining [Instill<br/>
        /// Credit](https://instill-ai.dev/docs/cloud/credit) of a given user or<br/>
        /// organization. The requested credit owner must be either the authenticated<br/>
        /// user or an organization they belong to.<br/>
        /// On Instill Core, this endpoint will return a 404 Not Found status.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetRemainingCreditResponse> GetRemainingCreditAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}