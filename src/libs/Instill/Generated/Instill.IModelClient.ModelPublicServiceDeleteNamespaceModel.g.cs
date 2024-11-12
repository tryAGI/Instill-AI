#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Delete a model<br/>
        /// Deletes a model, accesing it by its resource name, which is defined by the<br/>
        /// parent namespace and the ID of the model.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> ModelPublicServiceDeleteNamespaceModelAsync(
            string namespaceId,
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}