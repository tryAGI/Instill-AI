#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List component definitions<br/>
        /// Returns a paginated list of component definitions, regardless their type.<br/>
        /// This offers a single source of truth, with pagination and filter<br/>
        /// capabilities, for the components that might be used in a pipeline.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        global::System.Threading.Tasks.Task<global::Instill.ListComponentDefinitionsResponse> PipelinePublicServiceListComponentDefinitionsAsync(
            int? pageSize = default,
            global::Instill.PipelinePublicServiceListComponentDefinitionsView? view = default,
            string? filter = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}