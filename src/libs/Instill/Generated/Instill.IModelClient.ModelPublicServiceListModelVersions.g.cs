#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List namespace model versions<br/>
        /// Returns a paginated list of version of a model namespace that belong to the<br/>
        /// specified namespace. Contains model version and digest.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Instill.ListModelVersionsResponse> ModelPublicServiceListModelVersionsAsync(
            string parent,
            int? pageSize = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}