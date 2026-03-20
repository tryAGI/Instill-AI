#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {

        /// <summary>
        /// Get a pipeline release<br/>
        /// Gets the details of a pipeline release, where the pipeline is identified<br/>
        /// by its resource name, formed by its parent namespace and ID.
        /// </summary>
        /// <param name="name4"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetPipelineReleaseResponse> PipelinePublicServiceGetPipelineReleaseAsync(
            string name4,
            global::Instill.PipelinePublicServiceGetPipelineReleaseView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}