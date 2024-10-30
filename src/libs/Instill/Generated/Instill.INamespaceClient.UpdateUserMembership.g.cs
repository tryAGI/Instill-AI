#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::Instill.UserMembership request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="state">
        /// State of the membership.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::Instill.MembershipState state,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}