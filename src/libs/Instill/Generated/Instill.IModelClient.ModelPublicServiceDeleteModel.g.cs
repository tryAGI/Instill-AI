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
        /// <param name="name3"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<string> ModelPublicServiceDeleteModelAsync(
            string name3,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}