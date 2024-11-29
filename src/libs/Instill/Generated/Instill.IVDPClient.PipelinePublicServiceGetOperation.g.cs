#nullable enable

namespace Instill
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Get the details of a long-running operation<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations such as asynchronous pipeline triggers.
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetOperationResponse> PipelinePublicServiceGetOperationAsync(
            string operationId,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}