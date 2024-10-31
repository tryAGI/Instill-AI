#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Accesses and deletes an organization by ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<string> DeleteOrganizationAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}