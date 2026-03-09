#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Delete a model version<br/>
        /// Deletes a model version, accesing it by its resource name, which is defined<br/>
        /// by the parent namespace and the ID of the model, and version.
        /// </summary>
        /// <param name="name4"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelPublicServiceDeleteModelVersionAsync(
            string name4,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}