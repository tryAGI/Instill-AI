
#nullable enable

namespace Instill
{
    public partial class x__VDPClient
    {
        partial void PreparePipelinePublicServiceListNamespacePipelinesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref int? pageSize,
            ref string? pageToken,
            ref global::Instill.PipelinePublicServiceListNamespacePipelinesView? view,
            ref string? filter,
            ref bool? showDeleted,
            ref global::Instill.PipelinePublicServiceListNamespacePipelinesVisibility? visibility,
            ref string? orderBy);
        partial void PreparePipelinePublicServiceListNamespacePipelinesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            int? pageSize,
            string? pageToken,
            global::Instill.PipelinePublicServiceListNamespacePipelinesView? view,
            string? filter,
            bool? showDeleted,
            global::Instill.PipelinePublicServiceListNamespacePipelinesVisibility? visibility,
            string? orderBy);
        partial void ProcessPipelinePublicServiceListNamespacePipelinesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceListNamespacePipelinesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List namespace pipelines<br/>
        /// Returns a paginated list of pipelines of a namespace
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.ListNamespacePipelinesResponse> PipelinePublicServiceListNamespacePipelinesAsync(
            string namespaceId,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.PipelinePublicServiceListNamespacePipelinesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::Instill.PipelinePublicServiceListNamespacePipelinesVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceListNamespacePipelinesArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                view: ref view,
                filter: ref filter,
                showDeleted: ref showDeleted,
                visibility: ref visibility,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/pipelines",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("pageToken", pageToken) 
                .AddOptionalParameter("view", view?.ToValueString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("showDeleted", showDeleted?.ToString()) 
                .AddOptionalParameter("visibility", visibility?.ToValueString()) 
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
            PreparePipelinePublicServiceListNamespacePipelinesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                showDeleted: showDeleted,
                visibility: visibility,
                orderBy: orderBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceListNamespacePipelinesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPipelinePublicServiceListNamespacePipelinesResponseContent(
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
                global::Instill.ListNamespacePipelinesResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}