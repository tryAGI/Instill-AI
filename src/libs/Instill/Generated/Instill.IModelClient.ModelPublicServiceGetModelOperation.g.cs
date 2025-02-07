#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of a long-running operation<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetModelOperationResponse> ModelPublicServiceGetModelOperationAsync(
            string operationId,
            global::Instill.ModelPublicServiceGetModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}