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
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetNamespaceModelResponse> ModelPublicServiceGetNamespaceModelAsync(
            string namespaceId,
            string modelId,
            global::Instill.ModelPublicServiceGetNamespaceModelView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}