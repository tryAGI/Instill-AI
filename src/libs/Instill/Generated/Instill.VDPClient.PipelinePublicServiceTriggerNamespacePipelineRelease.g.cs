
#nullable enable

namespace Instill
{
    public partial class VDPClient
    {
        partial void PreparePipelinePublicServiceTriggerNamespacePipelineReleaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string pipelineId,
            ref string releaseId,
            ref string? instillRequesterUid,
            global::Instill.TriggerNamespacePipelineReleaseBody request);
        partial void PreparePipelinePublicServiceTriggerNamespacePipelineReleaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid,
            global::Instill.TriggerNamespacePipelineReleaseBody request);
        partial void ProcessPipelinePublicServiceTriggerNamespacePipelineReleaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceTriggerNamespacePipelineReleaseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trigger a pipeline release<br/>
        /// Triggers the synchronous execution of of a pipeline. While the trigger<br/>
        /// endpoint (where the release version isn't specified) triggers the pipeline<br/>
        /// at its latest release, this method allows the client to specified any<br/>
        /// committed release.<br/>
        /// The pipeline is identified by its resource name, formed by its parent namespace<br/>
        /// and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.TriggerNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::Instill.TriggerNamespacePipelineReleaseBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceTriggerNamespacePipelineReleaseArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pipelineId: ref pipelineId,
                releaseId: ref releaseId,
                instillRequesterUid: ref instillRequesterUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/pipelines/{pipelineId}/releases/{releaseId}/trigger",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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

            if (instillRequesterUid != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Instill-Requester-Uid", instillRequesterUid.ToString());
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
            PreparePipelinePublicServiceTriggerNamespacePipelineReleaseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                instillRequesterUid: instillRequesterUid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceTriggerNamespacePipelineReleaseResponse(
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
                ProcessPipelinePublicServiceTriggerNamespacePipelineReleaseResponseContent(
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
                    global::Instill.TriggerNamespacePipelineReleaseResponse.FromJson(__content, JsonSerializerContext) ??
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
                    await global::Instill.TriggerNamespacePipelineReleaseResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Trigger a pipeline release<br/>
        /// Triggers the synchronous execution of of a pipeline. While the trigger<br/>
        /// endpoint (where the release version isn't specified) triggers the pipeline<br/>
        /// at its latest release, this method allows the client to specified any<br/>
        /// committed release.<br/>
        /// The pipeline is identified by its resource name, formed by its parent namespace<br/>
        /// and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.TriggerNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.TriggerNamespacePipelineReleaseBody
            {
                Inputs = inputs,
                Data = data,
            };

            return await PipelinePublicServiceTriggerNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                instillRequesterUid: instillRequesterUid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}