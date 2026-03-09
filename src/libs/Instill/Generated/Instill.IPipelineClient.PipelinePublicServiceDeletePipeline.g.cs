#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Delete a pipeline<br/>
        /// Deletes a pipeline, accesing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated<br/>
        /// namespace must be the parent of the pipeline in order to delete it.
        /// </summary>
        /// <param name="name2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeletePipelineAsync(
            string name2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}