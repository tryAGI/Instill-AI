#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Validate a pipeline<br/>
        /// Validates a pipeline by its resource name, which is defined by the parent<br/>
        /// namespace and the ID of the pipeline.<br/>
        /// Validation checks the recipe of the pipeline and the status of its<br/>
        /// components.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ValidatePipelineResponse> PipelinePublicServiceValidatePipelineAsync(
            string name,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Validate a pipeline<br/>
        /// Validates a pipeline by its resource name, which is defined by the parent<br/>
        /// namespace and the ID of the pipeline.<br/>
        /// Validation checks the recipe of the pipeline and the status of its<br/>
        /// components.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ValidatePipelineResponse> PipelinePublicServiceValidatePipelineAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}