
#nullable enable

namespace Instill
{
    public partial class AppClient
    {
        partial void PrepareAppPublicServiceUpdateConversationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string appId,
            ref string conversationId,
            global::Instill.UpdateConversationBody request);
        partial void PrepareAppPublicServiceUpdateConversationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string appId,
            string conversationId,
            global::Instill.UpdateConversationBody request);
        partial void ProcessAppPublicServiceUpdateConversationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppPublicServiceUpdateConversationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a conversation<br/>
        /// Updates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateConversationResponse> AppPublicServiceUpdateConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            global::Instill.UpdateConversationBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAppPublicServiceUpdateConversationArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                appId: ref appId,
                conversationId: ref conversationId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1alpha/namespaces/{namespaceId}/apps/{appId}/conversations/{conversationId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppPublicServiceUpdateConversationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppPublicServiceUpdateConversationResponse(
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
                ProcessAppPublicServiceUpdateConversationResponseContent(
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
                    global::Instill.UpdateConversationResponse.FromJson(__content, JsonSerializerContext) ??
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
                    await global::Instill.UpdateConversationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update a conversation<br/>
        /// Updates a conversation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="conversationId"></param>
        /// <param name="newConversationId"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateConversationResponse> AppPublicServiceUpdateConversationAsync(
            string namespaceId,
            string appId,
            string conversationId,
            string? newConversationId = default,
            string? lastUsedCatalogUid = default,
            long? lastUsedTopK = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.UpdateConversationBody
            {
                NewConversationId = newConversationId,
                LastUsedCatalogUid = lastUsedCatalogUid,
                LastUsedTopK = lastUsedTopK,
            };

            return await AppPublicServiceUpdateConversationAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}