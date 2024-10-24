#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List all apps info
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListAppsResponse> AppPublicServiceListAppsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}