#nullable enable

namespace Instill
{
    public partial interface IAppClient
    {
        /// <summary>
        /// Delete a app
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppPublicServiceDeleteAppAsync(
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}