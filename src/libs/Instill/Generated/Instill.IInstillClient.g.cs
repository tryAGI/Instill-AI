
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
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Namespaces (e.g. User, Organization) that structure the resource hierarchy.
        /// </summary>
        public NamespaceClient Namespace { get; }

        /// <summary>
        /// Pipeline orchestration in VDP (Versatile Data Pipeline).
        /// </summary>
        public VDPClient VDP { get; }

        /// <summary>
        /// AI Model resources for MLOps/LLMOps.
        /// </summary>
        public ModelClient Model { get; }

        /// <summary>
        /// Data orchestration for unified unstructured data representation.
        /// </summary>
        public ArtifactClient Artifact { get; }

        /// <summary>
        /// Ready-to-use AI agents.
        /// </summary>
        public AgentClient Agent { get; }

        /// <summary>
        /// Table resources for agents.
        /// </summary>
        public TableClient Table { get; }

        /// <summary>
        /// Resource usage metrics.
        /// </summary>
        public MetricsClient Metrics { get; }

        /// <summary>
        /// Pricing plans on Instill Cloud.
        /// </summary>
        public SubscriptionClient Subscription { get; }

    }
}