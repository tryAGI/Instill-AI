#nullable enable

namespace Instill
{
    public partial interface Ix__ModelClient
    {
        /// <summary>
        /// Get the details of a long-running operation<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetModelOperationResponse> ModelPublicServiceGetModelOperationAsync(
            string operationId,
            global::Instill.ModelPublicServiceGetModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}