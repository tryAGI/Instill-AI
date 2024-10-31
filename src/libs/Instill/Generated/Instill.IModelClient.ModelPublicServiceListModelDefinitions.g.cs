#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List model definitions<br/>
        /// Returns a paginated list of model definitions.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListModelDefinitionsResponse> ModelPublicServiceListModelDefinitionsAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.ModelPublicServiceListModelDefinitionsView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}