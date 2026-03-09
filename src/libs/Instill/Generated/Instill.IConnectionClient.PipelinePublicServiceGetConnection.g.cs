#nullable enable

namespace Instill
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Get a connection<br/>
        /// Returns the details of a connection.
        /// </summary>
        /// <param name="name6"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.GetConnectionResponse> PipelinePublicServiceGetConnectionAsync(
            string name6,
            global::Instill.PipelinePublicServiceGetConnectionView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}