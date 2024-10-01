
#nullable enable

namespace Instill
{
    public sealed partial class InstillClient
    {
        /// <inheritdoc cref="InstillClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Instill.EndPointAuthorization?)"/>
        public InstillClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Instill.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}