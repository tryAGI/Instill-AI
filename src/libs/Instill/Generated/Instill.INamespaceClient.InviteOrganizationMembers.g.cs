#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Invite members to an organization<br/>
        /// Invites members to an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> InviteOrganizationMembersAsync(
            string organizationId,
            global::Instill.InviteOrganizationMembersBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Invite members to an organization<br/>
        /// Invites members to an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="emails">
        /// The members to invite.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<string> InviteOrganizationMembersAsync(
            string organizationId,
            global::System.Collections.Generic.IList<string> emails,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}