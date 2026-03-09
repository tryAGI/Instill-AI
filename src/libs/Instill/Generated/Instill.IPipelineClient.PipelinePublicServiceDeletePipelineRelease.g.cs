#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Delete a pipeline release<br/>
        /// Deletes a pipeline release, where the pipeline is identified by its<br/>
        /// resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="name3"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeletePipelineReleaseAsync(
            string name3,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}