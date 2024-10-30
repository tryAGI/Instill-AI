
#nullable enable

namespace Instill
{
    public partial class VDPClient
    {
        partial void PreparePipelinePublicServiceTriggerNamespacePipelineWithStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string pipelineId,
            ref string? instillRequesterUid,
            global::Instill.TriggerNamespacePipelineWithStreamBody request);
        partial void PreparePipelinePublicServiceTriggerNamespacePipelineWithStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string pipelineId,
            string? instillRequesterUid,
            global::Instill.TriggerNamespacePipelineWithStreamBody request);
        partial void ProcessPipelinePublicServiceTriggerNamespacePipelineWithStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceTriggerNamespacePipelineWithStreamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the response.<br/>
        /// This method is intended for real-time inference when low latency is of concern<br/>
        /// and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse> PipelinePublicServiceTriggerNamespacePipelineWithStreamAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.TriggerNamespacePipelineWithStreamBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceTriggerNamespacePipelineWithStreamArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pipelineId: ref pipelineId,
                instillRequesterUid: ref instillRequesterUid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/pipelines/{pipelineId}/trigger-stream",
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
            PreparePipelinePublicServiceTriggerNamespacePipelineWithStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                instillRequesterUid: instillRequesterUid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceTriggerNamespacePipelineWithStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPipelinePublicServiceTriggerNamespacePipelineWithStreamResponseContent(
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
                global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the response.<br/>
        /// This method is intended for real-time inference when low latency is of concern<br/>
        /// and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse> PipelinePublicServiceTriggerNamespacePipelineWithStreamAsync(
            string namespaceId,
            string pipelineId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::Instill.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.TriggerNamespacePipelineWithStreamBody
            {
                Inputs = inputs,
                Data = data,
            };

            return await PipelinePublicServiceTriggerNamespacePipelineWithStreamAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                instillRequesterUid: instillRequesterUid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}