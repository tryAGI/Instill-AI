
#nullable enable

namespace Instill
{
    public partial class TokenClient
    {
        partial void PrepareCreateTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Instill.ApiToken request);
        partial void PrepareCreateTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Instill.ApiToken request);
        partial void ProcessCreateTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an API token<br/>
        /// Creates an API token for the authenticated user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.CreateTokenResponse> CreateTokenAsync(
            global::Instill.ApiToken request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTokenArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/tokens",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTokenRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTokenResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateTokenResponseContent(
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
                global::Instill.CreateTokenResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an API token<br/>
        /// Creates an API token for the authenticated user.
        /// </summary>
        /// <param name="lastUseTime">
        /// When users trigger a pipeline which uses an API token, the token is<br/>
        /// updated with the current time. This field is used to track the last time<br/>
        /// the token was used.
        /// </param>
        /// <param name="id">
        /// API token resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// This field can reflect the client(s) that will use the token.
        /// </param>
        /// <param name="ttl">
        /// The time-to-live in seconds for this resource.
        /// </param>
        /// <param name="expireTime">
        /// Expiration time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Instill.CreateTokenResponse> CreateTokenAsync(
            global::System.DateTime? lastUseTime = default,
            string? id = default,
            int? ttl = default,
            global::System.DateTime? expireTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Instill.ApiToken
            {
                LastUseTime = lastUseTime,
                Id = id,
                Ttl = ttl,
                ExpireTime = expireTime,
            };

            return await CreateTokenAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}