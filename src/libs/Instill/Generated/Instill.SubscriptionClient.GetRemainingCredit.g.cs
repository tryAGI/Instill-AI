
#nullable enable

namespace Instill
{
    public partial class SubscriptionClient
    {
        partial void PrepareGetRemainingCreditArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId);
        partial void PrepareGetRemainingCreditRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId);
        partial void ProcessGetRemainingCreditResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRemainingCreditResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the remaining Instill Credit<br/>
        /// This endpoint returns the remaining [Instill Credit](https://www.instill.tech/docs/vdp/credit) of a given user or<br/>
        /// organization. The requested credit owner must be either the authenticated<br/>
        /// user or an organization they belong to.<br/>
        /// On Instill Core, this endpoint will return a 404 Not Found status.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_BETA_001")]
        public async global::System.Threading.Tasks.Task<global::Instill.GetRemainingCreditResponse> GetRemainingCreditAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetRemainingCreditArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/namespaces/{namespaceId}/credit",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareGetRemainingCreditRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetRemainingCreditResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetRemainingCreditResponseContent(
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
                global::Instill.GetRemainingCreditResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}