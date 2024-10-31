#nullable enable

namespace Instill
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::Instill.Organization request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="profile">
        /// Profile.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::Instill.OrganizationProfile profile,
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}