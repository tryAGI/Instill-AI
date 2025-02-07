#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object Upload URL<br/>
        /// Returns the upload URL of an object.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectName"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetObjectUploadURLResponse> GetObjectUploadURLAsync(
            string namespaceId,
            string objectName,
            int? urlExpireDays = default,
            global::System.DateTime? lastModifiedTime = default,
            int? objectExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}