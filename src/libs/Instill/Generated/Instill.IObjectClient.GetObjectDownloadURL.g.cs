#nullable enable

namespace Instill
{
    public partial interface IObjectClient
    {
        /// <summary>
        /// Get Object Download URL
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectUid"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetObjectDownloadURLResponse> GetObjectDownloadURLAsync(
            string namespaceId,
            string objectUid,
            int? urlExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}