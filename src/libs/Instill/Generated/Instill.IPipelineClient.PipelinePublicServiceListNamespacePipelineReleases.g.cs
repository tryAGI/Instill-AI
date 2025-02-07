#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// List the releases in a pipeline<br/>
        /// Lists the commited versions of a pipeline, identified by its resource<br/>
        /// name, which is formed by the parent namespace and ID of the pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListNamespacePipelineReleasesResponse> PipelinePublicServiceListNamespacePipelineReleasesAsync(
            string namespaceId,
            string pipelineId,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.PipelinePublicServiceListNamespacePipelineReleasesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}