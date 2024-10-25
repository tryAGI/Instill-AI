
#nullable enable

namespace Instill
{
    /// <summary>
    /// Interact with Instill AI through its public API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class InstillClient : global::Instill.IInstillClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.instill.tech";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Instill.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Instill.SourceGenerationContext.Default;


        /// <summary>
        /// User namespaces
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Organization namespaces
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Organization memberships
        /// </summary>
        public MembershipClient Membership => new MembershipClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// API tokens
        /// </summary>
        public TokenClient Token => new TokenClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Subscriptions to pricing plans
        /// </summary>
        public SubscriptionClient Subscription => new SubscriptionClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Instill Credit
        /// </summary>
        public CreditClient Credit => new CreditClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Usage metrics
        /// </summary>
        public MetricClient Metric => new MetricClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model regions
        /// </summary>
        public RegionClient Region => new RegionClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Utils
        /// </summary>
        public UtilClient Util => new UtilClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Components
        /// </summary>
        public ComponentClient Component => new ComponentClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Pipelines
        /// </summary>
        public PipelineClient Pipeline => new PipelineClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Pipeline Releases
        /// </summary>
        public PipelineReleaseClient PipelineRelease => new PipelineReleaseClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Pipeline Triggers
        /// </summary>
        public PipelineTriggerClient PipelineTrigger => new PipelineTriggerClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Namespace Secrets
        /// </summary>
        public SecretClient Secret => new SecretClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Namespace Integrations
        /// </summary>
        public IntegrationClient Integration => new IntegrationClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model definitions
        /// </summary>
        public ModelDefinitionClient ModelDefinition => new ModelDefinitionClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Models
        /// </summary>
        public ModelClient Model => new ModelClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model versions
        /// </summary>
        public ModelVersionClient ModelVersion => new ModelVersionClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model triggers
        /// </summary>
        public ModelTriggerClient ModelTrigger => new ModelTriggerClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Catalogs
        /// </summary>
        public CatalogClient Catalog => new CatalogClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Objects
        /// </summary>
        public ObjectClient Object => new ObjectClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Apps
        /// </summary>
        public AppClient App => new AppClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Conversations
        /// </summary>
        public ConversationClient Conversation => new ConversationClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Messages
        /// </summary>
        public MessageClient Message => new MessageClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Playgrounds
        /// </summary>
        public PlaygroundClient Playground => new PlaygroundClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the InstillClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public InstillClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Instill.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Instill.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
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