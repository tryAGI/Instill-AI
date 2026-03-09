#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of the long-running operation from a model version<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetModelVersionOperationResponse> ModelPublicServiceGetModelVersionOperationAsync(
            string name,
            global::Instill.ModelPublicServiceGetModelVersionOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}