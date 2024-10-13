
#nullable enable

namespace Instill
{
    public partial class CatalogClient
    {
        partial void PrepareProcessCatalogFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? instillRequesterUid,
            global::Instill.ProcessCatalogFilesRequest request);
        partial void PrepareProcessCatalogFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? instillRequesterUid,
            global::Instill.ProcessCatalogFilesRequest request);
        partial void ProcessProcessCatalogFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProcessCatalogFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::Instill.ProcessCatalogFilesRequest request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareProcessCatalogFilesArguments(
                httpClient: _httpClient,
                instillRequesterUid: ref instillRequesterUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1alpha/catalogs/files/processAsync",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (instillRequesterUid != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("Instill-Requester-Uid", instillRequesterUid.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProcessCatalogFilesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                instillRequesterUid: instillRequesterUid,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProcessCatalogFilesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProcessCatalogFilesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Instill.ProcessCatalogFilesResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Process catalog files
        /// </summary>
        /// <param name="instillRequesterUid"></param>
        /// <param name="fileUids">
        /// The file uid.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.ProcessCatalogFilesResponse> ProcessCatalogFilesAsync(
            global::System.Collections.Generic.IList<string> fileUids,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Instill.ProcessCatalogFilesRequest
            {
                FileUids = fileUids,
            };

            return await ProcessCatalogFilesAsync(
                instillRequesterUid: instillRequesterUid,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}