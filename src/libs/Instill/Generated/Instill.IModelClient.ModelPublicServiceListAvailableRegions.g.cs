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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListAvailableRegionsResponse> ModelPublicServiceListAvailableRegionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}