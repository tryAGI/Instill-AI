#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object Download URL<br/>
        /// Returns the download URL of an object.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="downloadFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetObjectDownloadURLResponse> ArtifactPublicServiceGetObjectDownloadURLAsync(
            string name,
            int? urlExpireDays = default,
            string? downloadFilename = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}