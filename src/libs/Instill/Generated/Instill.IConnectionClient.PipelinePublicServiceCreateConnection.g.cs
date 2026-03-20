#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {

        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="parent1"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateConnectionResponse> PipelinePublicServiceCreateConnectionAsync(
            string parent1,

            global::Instill.PipelineV1betaConnection request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a connection<br/>
        /// Creates a connection under the ownership of a namespace.
        /// </summary>
        /// <param name="parent1"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name for UI.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="integrationId">
        /// Field 10: Integration ID. It determines for which type of components can<br/>
        /// reference this connection.
        /// </param>
        /// <param name="method">
        /// Field 12: Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </param>
        /// <param name="setup">
        /// Field 13: Connection details. This field is required on creation, optional<br/>
        /// on view. When viewing the connection details, the setup values will be<br/>
        /// redacted.
        /// </param>
        /// <param name="scopes">
        /// Field 15: A list of scopes that identify the resources that the connection<br/>
        /// will be able to access on the user's behalf. This is typically passed on<br/>
        /// creation when the setup has been generated through an OAuth flow with a<br/>
        /// limited set of scopes.
        /// </param>
        /// <param name="oAuthAccessDetails">
        /// Field 16: When the connection method is METHOD_OAUTH, the access token<br/>
        /// might come with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </param>
        /// <param name="identity">
        /// Field 17: When the connection method is METHOD_OAUTH, this field will hold<br/>
        /// the identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateConnectionResponse> PipelinePublicServiceCreateConnectionAsync(
            string parent1,
            string displayName,
            string integrationId,
            global::Instill.PipelineV1betaConnectionMethod method,
            object setup,
            string? slug = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            object? oAuthAccessDetails = default,
            string? identity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}