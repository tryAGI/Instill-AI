
#nullable enable

namespace Instill
{
    /// <summary>
    /// Core endpoints to manage user resources<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class InstillClient : global::Instill.IInstillClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.instill.tech";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::Instill.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Instill.SourceGenerationContext.Default;


        /// <summary>
        /// User endpoints
        /// </summary>
        public UserClient User => new UserClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Organization endpoints
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Membership endpoints
        /// </summary>
        public MembershipClient Membership => new MembershipClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Token endpoints
        /// </summary>
        public TokenClient Token => new TokenClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Subscription endpoints
        /// </summary>
        public SubscriptionClient Subscription => new SubscriptionClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Credit endpoints
        /// </summary>
        public CreditClient Credit => new CreditClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Metric endpoints
        /// </summary>
        public MetricClient Metric => new MetricClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Util endpoints
        /// </summary>
        public UtilsClient Utils => new UtilsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CatalogClient Catalog => new CatalogClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the InstillClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorization"></param>
        public InstillClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Instill.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}