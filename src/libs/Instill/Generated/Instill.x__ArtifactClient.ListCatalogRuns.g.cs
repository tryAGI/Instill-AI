
#nullable enable

namespace Instill
{
    public partial class x__ArtifactClient
    {
        partial void PrepareListCatalogRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string catalogId,
            ref int? page,
            ref int? pageSize,
            ref string? filter,
            ref string? orderBy);
        partial void PrepareListCatalogRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string catalogId,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy);
        partial void ProcessListCatalogRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListCatalogRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Catalog Runs<br/>
        /// Returns a paginated list of catalog runs.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.ListCatalogRunsResponse> ListCatalogRunsAsync(
            string namespaceId,
            string catalogId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListCatalogRunsArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                catalogId: ref catalogId,
                page: ref page,
                pageSize: ref pageSize,
                filter: ref filter,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/catalogs/{catalogId}/runs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("orderBy", orderBy) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListCatalogRunsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                catalogId: catalogId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListCatalogRunsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListCatalogRunsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Instill.ListCatalogRunsResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}