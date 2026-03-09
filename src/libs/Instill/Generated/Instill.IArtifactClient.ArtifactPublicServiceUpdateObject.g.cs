#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update Object<br/>
        /// Updates an object.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateObjectResponse> ArtifactPublicServiceUpdateObjectAsync(
            string objectName,

            global::Instill.UpdateObjectBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Object<br/>
        /// Updates an object.
        /// </summary>
        /// <param name="objectName"></param>
        /// <param name="object"></param>
        /// <param name="updateMask">
        /// The update mask specifies which fields to update.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.UpdateObjectResponse> ArtifactPublicServiceUpdateObjectAsync(
            string objectName,
            global::Instill.UpdateObjectBodyObject @object,
            string? updateMask = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}