#nullable enable

namespace Instill
{
    public partial interface IPipelineClient
    {
        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceClonePipelineReleaseAsync(
            string name1,

            global::Instill.ClonePipelineReleaseBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a<br/>
        /// different parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="target"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceClonePipelineReleaseAsync(
            string name1,
            string target,
            string? description = default,
            global::Instill.Sharing? sharing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}