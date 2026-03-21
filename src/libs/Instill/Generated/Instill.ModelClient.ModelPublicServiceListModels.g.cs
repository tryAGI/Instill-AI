
#nullable enable

namespace Instill
{
    public partial class ModelClient
    {
        partial void PrepareModelPublicServiceListModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string parent,
            ref int? pageSize,
            ref string? pageToken,
            ref global::Instill.ModelPublicServiceListModelsView? view,
            ref bool? showDeleted,
            ref string? filter,
            ref global::Instill.ModelPublicServiceListModelsVisibility? visibility,
            ref string? orderBy);
        partial void PrepareModelPublicServiceListModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string parent,
            int? pageSize,
            string? pageToken,
            global::Instill.ModelPublicServiceListModelsView? view,
            bool? showDeleted,
            string? filter,
            global::Instill.ModelPublicServiceListModelsVisibility? visibility,
            string? orderBy);
        partial void ProcessModelPublicServiceListModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelPublicServiceListModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List models<br/>
        /// Returns a paginated list of models.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="showDeleted"></param>
        /// <param name="filter"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::Instill.ListModelsResponse> ModelPublicServiceListModelsAsync(
            string parent,
            int? pageSize = default,
            string? pageToken = default,
            global::Instill.ModelPublicServiceListModelsView? view = default,
            bool? showDeleted = default,
            string? filter = default,
            global::Instill.ModelPublicServiceListModelsVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelPublicServiceListModelsArguments(
                httpClient: HttpClient,
                parent: ref parent,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                view: ref view,
                showDeleted: ref showDeleted,
                filter: ref filter,
                visibility: ref visibility,
                orderBy: ref orderBy);

            var __pathBuilder = new global::Instill.PathBuilder(
                path: $"/v1alpha/{parent}/models",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("pageToken", pageToken)
                .AddOptionalParameter("view", view?.ToValueString())
                .AddOptionalParameter("showDeleted", showDeleted?.ToString().ToLowerInvariant())
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("visibility", visibility?.ToValueString())
                .AddOptionalParameter("orderBy", orderBy) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareModelPublicServiceListModelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                parent: parent,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
                visibility: visibility,
                orderBy: orderBy);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModelPublicServiceListModelsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when the client credentials are not valid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                string? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext) as string;
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::System.Text.Json.JsonSerializer.Deserialize(__content_401, typeof(string), JsonSerializerContext) as string;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Instill.ApiException<string>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
                global::System.Exception? __exception_default = null;
                global::Instill.RpcStatus? __value_default = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_default = global::Instill.RpcStatus.FromJson(__content_default, JsonSerializerContext);
                    }
                    else
                    {
                        __content_default = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_default = global::Instill.RpcStatus.FromJson(__content_default, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_default = __ex;
                }

                throw new global::Instill.ApiException<global::Instill.RpcStatus>(
                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_default,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessModelPublicServiceListModelsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Instill.ListModelsResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Instill.ListModelsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
            }
        }
    }
}