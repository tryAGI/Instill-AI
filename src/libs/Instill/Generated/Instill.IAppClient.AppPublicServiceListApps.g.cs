#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List all apps info<br/>
        /// Returns a paginated list of apps.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListAppsResponse> AppPublicServiceListAppsAsync(
            string namespaceId,
            global::Instill.AppPublicServiceListAppsAppType? appType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}