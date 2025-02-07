#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Watch the state of a model version<br/>
        /// Returns the state of a model. The model resource allocation and scaling actions take some<br/>
        /// time, during which a model will be in various state. This endpoint<br/>
        /// allows clients to track the state.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.WatchNamespaceModelResponse> ModelPublicServiceWatchNamespaceModelAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}