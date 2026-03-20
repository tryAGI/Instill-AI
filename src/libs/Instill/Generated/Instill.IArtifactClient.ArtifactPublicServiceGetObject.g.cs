#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object<br/>
        /// Returns the details of an object.
        /// </summary>
        /// <param name="name3"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetObjectResponse> ArtifactPublicServiceGetObjectAsync(
            string name3,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}