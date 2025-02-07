#nullable enable

namespace Instill
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List namespace model versions<br/>
        /// Returns a paginated list of version of a model namespace that belong to the specified namespace.<br/>
        /// Contains model version and digest.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.ListNamespaceModelVersionsResponse> ModelPublicServiceListNamespaceModelVersionsAsync(
            string namespaceId,
            string modelId,
            int? pageSize = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}