#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List namespace pipelines<br/>
        /// Returns a paginated list of pipelines of a namespace
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListNamespacePipelinesResponse> PipelinePublicServiceListNamespacePipelinesAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.PipelinePublicServiceListNamespacePipelinesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::Instill.PipelinePublicServiceListNamespacePipelinesVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}