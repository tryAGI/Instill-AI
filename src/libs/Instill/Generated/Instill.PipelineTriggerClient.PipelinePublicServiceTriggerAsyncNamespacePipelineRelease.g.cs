
#nullable enable

namespace Instill
{
    public partial class PipelineTriggerClient
    {
        partial void PreparePipelinePublicServiceTriggerAsyncNamespacePipelineReleaseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string pipelineId,
            ref string releaseId,
            ref string? instillRequesterUid,
            global::Instill.PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseBody request);
        partial void PreparePipelinePublicServiceTriggerAsyncNamespacePipelineReleaseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid,
            global::Instill.PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseBody request);
        partial void ProcessPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trigger a pipeline release asynchronously<br/>
        /// Triggers the asynchronous execution of of a pipeline. While the trigger<br/>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::Instill.PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceTriggerAsyncNamespacePipelineReleaseArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pipelineId: ref pipelineId,
                releaseId: ref releaseId,
                instillRequesterUid: ref instillRequesterUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/pipelines/{pipelineId}/releases/{releaseId}/trigger-async",
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
            PreparePipelinePublicServiceTriggerAsyncNamespacePipelineReleaseRequest(
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
            ProcessPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPipelinePublicServiceTriggerAsyncNamespacePipelineReleaseResponseContent(
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
                global::Instill.TriggerAsyncNamespacePipelineReleaseResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Trigger a pipeline release asynchronously<br/>
        /// Triggers the asynchronous execution of of a pipeline. While the trigger<br/>
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
        public async global::System.Threading.Tasks.Task<global::Instill.TriggerAsyncNamespacePipelineReleaseResponse> PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseBody
            {
                Inputs = inputs,
                Data = data,
            };

            return await PipelinePublicServiceTriggerAsyncNamespacePipelineReleaseAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                releaseId: releaseId,
                instillRequesterUid: instillRequesterUid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}