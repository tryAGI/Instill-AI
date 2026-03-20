#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {

        /// <summary>
        /// Get a pipeline<br/>
        /// Returns the details of a pipeline.
        /// </summary>
        /// <param name="name3"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.GetPipelineResponse> PipelinePublicServiceGetPipelineAsync(
            string name3,
            global::Instill.PipelinePublicServiceGetPipelineView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}