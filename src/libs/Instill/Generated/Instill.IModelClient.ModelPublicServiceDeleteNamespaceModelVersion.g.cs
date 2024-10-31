#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Delete a model version<br/>
        /// Deletes a model version, accesing it by its resource name, which is defined by the<br/>
        /// parent namespace and the ID of the model, and version.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<string> ModelPublicServiceDeleteNamespaceModelVersionAsync(
            string namespaceId,
            string modelId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}