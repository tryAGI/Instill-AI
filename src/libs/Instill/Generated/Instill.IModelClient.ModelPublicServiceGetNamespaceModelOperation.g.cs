#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get the details of the long-running operation from a namespace model<br/>
        /// with a particular version<br/>
        /// This method allows requesters to request the status and outcome of<br/>
        /// long-running operations in a model, such as trigger.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceModelOperationResponse> ModelPublicServiceGetNamespaceModelOperationAsync(
            string namespaceId,
            string modelId,
            string version,
            global::Instill.ModelPublicServiceGetNamespaceModelOperationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}