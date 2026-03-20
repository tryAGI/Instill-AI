#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {

        /// <summary>
        /// Delete Object<br/>
        /// Deletes an object.
        /// </summary>
        /// <param name="name2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> ArtifactPublicServiceDeleteObjectAsync(
            string name2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}