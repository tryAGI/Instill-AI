#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of the latest long-running operation from a model<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetModelOperationResponse> ModelPublicServiceGetModelOperationAsync(
            string name1,
            global::Instill.ModelPublicServiceGetModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}