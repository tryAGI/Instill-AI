
#nullable enable

namespace Instill
{
    public partial class x__VDPClient
    {
        partial void PreparePipelinePublicServiceUpdateNamespacePipelineArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string pipelineId,
            global::Instill.Pipeline request);
        partial void PreparePipelinePublicServiceUpdateNamespacePipelineRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string pipelineId,
            global::Instill.Pipeline request);
        partial void ProcessPipelinePublicServiceUpdateNamespacePipelineResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPipelinePublicServiceUpdateNamespacePipelineResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a pipeline<br/>
        /// Udpates a pipeline, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated namespace must be<br/>
        /// the parent of the pipeline in order to modify it.<br/>
        /// In REST requests, only the supplied pipeline fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateNamespacePipelineResponse> PipelinePublicServiceUpdateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::Instill.Pipeline request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePipelinePublicServiceUpdateNamespacePipelineArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                pipelineId: ref pipelineId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/pipelines/{pipelineId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PreparePipelinePublicServiceUpdateNamespacePipelineRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPipelinePublicServiceUpdateNamespacePipelineResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPipelinePublicServiceUpdateNamespacePipelineResponseContent(
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
                global::Instill.UpdateNamespacePipelineResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a pipeline<br/>
        /// Udpates a pipeline, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated namespace must be<br/>
        /// the parent of the pipeline in order to modify it.<br/>
        /// In REST requests, only the supplied pipeline fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="id">
        /// Pipeline resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="recipe">
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="metadata">
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </param>
        /// <param name="readme">
        /// README holds the pipeline documentation.
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the pipeline is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Pipeline profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.UpdateNamespacePipelineResponse> PipelinePublicServiceUpdateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            object recipe,
            string? id = default,
            string? description = default,
            global::Instill.Sharing? sharing = default,
            object? metadata = default,
            string? readme = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? rawRecipe = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.Pipeline
            {
                Id = id,
                Description = description,
                Recipe = recipe,
                Sharing = sharing,
                Metadata = metadata,
                Readme = readme,
                Tags = tags,
                RawRecipe = rawRecipe,
                SourceUrl = sourceUrl,
                DocumentationUrl = documentationUrl,
                License = license,
                ProfileImage = profileImage,
            };

            return await PipelinePublicServiceUpdateNamespacePipelineAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}