#nullable enable

namespace Instill
{
    public partial interface IObjectClient
    {
        /// <summary>
        /// Get Object Upload URL
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectName"></param>
        /// <param name="expirationTime"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetObjectUploadURLResponse> GetObjectUploadURLAsync(
            string namespaceId,
            string objectName,
            int? expirationTime = default,
            global::System.DateTime? lastModifiedTime = default,
            int? objectExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}