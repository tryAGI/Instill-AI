#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get a model definition<br/>
        /// Returns the details of a model definition.
        /// </summary>
        /// <param name="modelDefinitionId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetModelDefinitionResponse> ModelPublicServiceGetModelDefinitionAsync(
            string modelDefinitionId,
            global::Instill.ModelPublicServiceGetModelDefinitionView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}