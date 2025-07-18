#nullable enable

namespace Instill
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// List subscription free trials<br/>
        /// Returns a list of the free trials of the authenticated user. The trials<br/>
        /// might apply to different plans, including organization plans purchased by<br/>
        /// the user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListSubscriptionFreeTrialsResponse> ListSubscriptionFreeTrialsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}