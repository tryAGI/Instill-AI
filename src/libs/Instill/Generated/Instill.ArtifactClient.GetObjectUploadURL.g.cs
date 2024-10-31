
#nullable enable

namespace Instill
{
    public partial class ArtifactClient
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
        /// Get Object Upload URL<br/>
        /// Returns the upload URL of an object.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="objectName"></param>
        /// <param name="urlExpireDays"></param>
        /// <param name="lastModifiedTime"></param>
        /// <param name="objectExpireDays"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.GetObjectUploadURLResponse> GetObjectUploadURLAsync(
            string namespaceId,
            string objectName,
            int? urlExpireDays = default,
            global::System.DateTime? lastModifiedTime = default,
            int? objectExpireDays = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetObjectUploadURLArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                objectName: ref objectName,
                urlExpireDays: ref urlExpireDays,
                lastModifiedTime: ref lastModifiedTime,
                objectExpireDays: ref objectExpireDays);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/object-upload-url",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("objectName", objectName) 
                .AddOptionalParameter("urlExpireDays", urlExpireDays?.ToString()) 
                .AddOptionalParameter("lastModifiedTime", lastModifiedTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("objectExpireDays", objectExpireDays?.ToString()) 
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
            PrepareGetObjectUploadURLRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                objectName: objectName,
                urlExpireDays: urlExpireDays,
                lastModifiedTime: lastModifiedTime,
                objectExpireDays: objectExpireDays);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetObjectUploadURLResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetObjectUploadURLResponseContent(
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
                global::Instill.GetObjectUploadURLResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}