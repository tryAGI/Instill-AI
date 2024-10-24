
#nullable enable

namespace Instill
{
    public partial class ObjectClient
    {
        partial void PrepareGetObjectDownloadURLArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string? objectUid,
            ref string? objectName,
            ref int? urlExpireDays);
        partial void PrepareGetObjectDownloadURLRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string? objectUid,
            string? objectName,
            int? urlExpireDays);
        partial void ProcessGetObjectDownloadURLResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetObjectDownloadURLResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Object Download URL
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectUid"></param>
        /// <param name="objectName"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.GetObjectDownloadURLResponse> GetObjectDownloadURLAsync(
            string namespaceId,
            string? objectUid = default,
            string? objectName = default,
            int? urlExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetObjectDownloadURLArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                objectUid: ref objectUid,
                objectName: ref objectName,
                urlExpireDays: ref urlExpireDays);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/object-download-url",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("objectUid", objectUid) 
                .AddOptionalParameter("objectName", objectName) 
                .AddOptionalParameter("urlExpireDays", urlExpireDays?.ToString()) 
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
            PrepareGetObjectDownloadURLRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                objectUid: objectUid,
                objectName: objectName,
                urlExpireDays: urlExpireDays);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetObjectDownloadURLResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetObjectDownloadURLResponseContent(
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
                global::Instill.GetObjectDownloadURLResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}