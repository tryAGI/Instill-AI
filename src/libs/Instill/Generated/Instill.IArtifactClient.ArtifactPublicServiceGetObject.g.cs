#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Get Object<br/>
        /// Returns the details of an object.
        /// </summary>
        /// <param name="name3"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetObjectResponse> ArtifactPublicServiceGetObjectAsync(
            string name3,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}