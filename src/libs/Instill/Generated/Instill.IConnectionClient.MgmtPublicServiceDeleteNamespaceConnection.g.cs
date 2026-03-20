#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {

        /// <summary>
        /// Delete a connection<br/>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> MgmtPublicServiceDeleteNamespaceConnectionAsync(
            string name1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}