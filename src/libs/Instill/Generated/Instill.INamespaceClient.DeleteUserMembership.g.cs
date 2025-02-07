#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete a user membership<br/>
        /// Accesses and deletes a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> DeleteUserMembershipAsync(
            string userId,
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}