#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get the authenticated user<br/>
        /// Returns the details of the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetAuthenticatedUserResponse> GetAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}