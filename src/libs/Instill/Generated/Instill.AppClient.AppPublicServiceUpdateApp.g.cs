
#nullable enable

namespace Instill
{
    public partial class AppClient
    {
        partial void PrepareAppPublicServiceUpdateAppArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string appId,
            global::Instill.UpdateAppBody request);
        partial void PrepareAppPublicServiceUpdateAppRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string appId,
            global::Instill.UpdateAppBody request);
        partial void ProcessAppPublicServiceUpdateAppResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppPublicServiceUpdateAppResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an app's information<br/>
        /// Updates the information of an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateAppResponse> AppPublicServiceUpdateAppAsync(
            string namespaceId,
            string appId,
            global::Instill.UpdateAppBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAppPublicServiceUpdateAppArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                appId: ref appId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/apps/{appId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppPublicServiceUpdateAppRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                appId: appId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppPublicServiceUpdateAppResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when the client credentials are not valid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext) as string;
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_401, typeof(string), JsonSerializerContext).ConfigureAwait(false) as string;
                }

                throw new global::Instill.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // An unexpected error response.
            if (!__response.IsSuccessStatusCode)
            {
                string? __content_default = null;
                global::Instill.RpcStatus? __value_default = null;
                if (ReadResponseAsString)
                {
                    __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = global::Instill.RpcStatus.FromJson(__content_default, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_default = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_default = await global::Instill.RpcStatus.FromJsonStreamAsync(__contentStream_default, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Instill.ApiException<global::Instill.RpcStatus>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_default,
                    ResponseObject = __value_default,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAppPublicServiceUpdateAppResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Instill.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Instill.UpdateAppResponse.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Instill.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Instill.UpdateAppResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update an app's information<br/>
        /// Updates the information of an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="newAppId">
        /// The app id needs to follow the kebab case format.<br/>
        /// if the new app id is not provided, the app id will not be updated.
        /// </param>
        /// <param name="newDescription">
        /// The app description.<br/>
        /// If the new description is empty, the description will be set to empty.
        /// </param>
        /// <param name="newTags">
        /// The app tags.<br/>
        /// If the new tags is empty, the tags will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppCatalogUid">
        /// last AI assistant app catalog uid<br/>
        /// If the last AI assistant app catalog uid is empty, the last AI assistant app catalog uid will be set to empty.
        /// </param>
        /// <param name="lastAiAssistantAppTopK">
        /// last AI assistant app top k<br/>
        /// If the last AI assistant app top k is empty, the last AI assistant app top k will be set to empty.
        /// </param>
        /// <param name="aiAssistantApp"></param>
        /// <param name="aiAgentApp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateAppResponse> AppPublicServiceUpdateAppAsync(
            string namespaceId,
            string appId,
            string? newAppId = default,
            string? newDescription = default,
            global::System.Collections.Generic.IList<string>? newTags = default,
            string? lastAiAssistantAppCatalogUid = default,
            int? lastAiAssistantAppTopK = default,
            global::Instill.AIAssistantAppMetadata? aiAssistantApp = default,
            global::Instill.AIAgentAppMetadata? aiAgentApp = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.UpdateAppBody
            {
                NewAppId = newAppId,
                NewDescription = newDescription,
                NewTags = newTags,
                LastAiAssistantAppCatalogUid = lastAiAssistantAppCatalogUid,
                LastAiAssistantAppTopK = lastAiAssistantAppTopK,
                AiAssistantApp = aiAssistantApp,
                AiAgentApp = aiAgentApp,
            };

            return await AppPublicServiceUpdateAppAsync(
                namespaceId: namespaceId,
                appId: appId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}