#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Rename a model<br/>
        /// Renames a model, accesing it by its resource name, which is defined by the<br/>
        /// parent namespace and the ID of the model.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenameModelResponse> ModelPublicServiceRenameModelAsync(
            string name,

            global::Instill.RenameModelBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename a model<br/>
        /// Renames a model, accesing it by its resource name, which is defined by the<br/>
        /// parent namespace and the ID of the model.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="newModelId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace}/models/{new_model_id}`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.RenameModelResponse> ModelPublicServiceRenameModelAsync(
            string name,
            string newModelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}