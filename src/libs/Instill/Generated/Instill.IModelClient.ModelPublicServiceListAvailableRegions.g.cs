#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List available regions<br/>
        /// Returns a paginated list of available regions.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListAvailableRegionsResponse> ModelPublicServiceListAvailableRegionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}