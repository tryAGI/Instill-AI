#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get a model<br/>
        /// Returns the detail of a model, accessing it by the model ID and its parent<br/>
        /// namespace.
        /// </summary>
        /// <param name="name4"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetModelResponse> ModelPublicServiceGetModelAsync(
            string name4,
            global::Instill.ModelPublicServiceGetModelView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}