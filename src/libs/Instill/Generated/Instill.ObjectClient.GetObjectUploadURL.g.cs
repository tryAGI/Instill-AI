
#nullable enable

namespace Instill
{
    public partial class ObjectClient
    {
        partial void PrepareGetObjectUploadURLArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string objectName,
            ref int? urlExpireDays,
            ref global::System.DateTime? lastModifiedTime,
            ref int? objectExpireDays);
        partial void PrepareGetObjectUploadURLRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string objectName,
            int? urlExpireDays,
            global::System.DateTime? lastModifiedTime,
            int? objectExpireDays);
        partial void ProcessGetObjectUploadURLResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetObjectUploadURLResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Object Upload URL
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectName"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.GetObjectUploadURLResponse> GetObjectUploadURLAsync(
            string namespaceId,
            string objectName,
            int? urlExpireDays = default,
            global::System.DateTime? lastModifiedTime = default,
            int? objectExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetObjectUploadURLArguments(
                httpClient: _httpClient,
                namespaceId: ref namespaceId,
                objectName: ref objectName,
                urlExpireDays: ref urlExpireDays,
                lastModifiedTime: ref lastModifiedTime,
                objectExpireDays: ref objectExpireDays);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/object-upload-url",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("objectName", objectName) 
                .AddOptionalParameter("urlExpireDays", urlExpireDays?.ToString()) 
                .AddOptionalParameter("lastModifiedTime", lastModifiedTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("objectExpireDays", objectExpireDays?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetObjectUploadURLRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                namespaceId: namespaceId,
                objectName: objectName,
                urlExpireDays: urlExpireDays,
                lastModifiedTime: lastModifiedTime,
                objectExpireDays: objectExpireDays);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetObjectUploadURLResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetObjectUploadURLResponseContent(
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
                global::Instill.GetObjectUploadURLResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}