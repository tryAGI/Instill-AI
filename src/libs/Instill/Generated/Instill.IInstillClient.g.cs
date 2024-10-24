
#nullable enable

namespace Instill
{
    /// <summary>
    /// Interact with Instill AI through its public API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IInstillClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Instill.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// User namespaces
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// Organization namespaces
        /// </summary>
        public OrganizationClient Organization { get; }

        /// <summary>
        /// Organization memberships
        /// </summary>
        public MembershipsClient Memberships { get; }

        /// <summary>
        /// API tokens
        /// </summary>
        public TokenClient Token { get; }

        /// <summary>
        /// Subscriptions to pricing plans
        /// </summary>
        public SubscriptionClient Subscription { get; }

        /// <summary>
        /// Instill Credit
        /// </summary>
        public CreditClient Credit { get; }

        /// <summary>
        /// Usage metrics
        /// </summary>
        public MetricClient Metric { get; }

        /// <summary>
        /// Model regions
        /// </summary>
        public RegionClient Region { get; }

        /// <summary>
        /// Utils
        /// </summary>
        public UtilClient Util { get; }

        /// <summary>
        /// Components
        /// </summary>
        public ComponentClient Component { get; }

        /// <summary>
        /// Pipelines
        /// </summary>
        public PipelineClient Pipeline { get; }

        /// <summary>
        /// Pipeline Releases
        /// </summary>
        public PipelineReleaseClient PipelineRelease { get; }

        /// <summary>
        /// Pipeline Triggers
        /// </summary>
        public PipelineTriggerClient PipelineTrigger { get; }

        /// <summary>
        /// Namespace Secrets
        /// </summary>
        public SecretClient Secret { get; }

        /// <summary>
        /// Namespace Integrations
        /// </summary>
        public IntegrationClient Integration { get; }

        /// <summary>
        /// Model definitions
        /// </summary>
        public ModelDefinitionClient ModelDefinition { get; }

        /// <summary>
        /// Models
        /// </summary>
        public ModelClient Model { get; }

        /// <summary>
        /// Model versions
        /// </summary>
        public ModelVersionClient ModelVersion { get; }

        /// <summary>
        /// Model triggers
        /// </summary>
        public ModelTriggerClient ModelTrigger { get; }

        /// <summary>
        /// Catalogs
        /// </summary>
        public CatalogClient Catalog { get; }

        /// <summary>
        /// Apps
        /// </summary>
        public AppClient App { get; }

        /// <summary>
        /// Conversations
        /// </summary>
        public ConversationClient Conversation { get; }

        /// <summary>
        /// Messages
        /// </summary>
        public MessageClient Message { get; }

        /// <summary>
        /// Playgrounds
        /// </summary>
        public PlaygroundClient Playground { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObjectClient Object { get; }

        /// <summary>
        /// 
        /// </summary>
        public MembershipClient Membership { get; }

        /// <summary>
        /// 
        /// </summary>
        public UtilsClient Utils { get; }

    }
}