
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
        /// Namespaces (e.g. User, Organization) that structure the resource hierarchy.
        /// </summary>
        public x__NamespaceClient x__Namespace { get; }

        /// <summary>
        /// Pipeline orchestration in VDP (Versatile Data Pipeline).
        /// </summary>
        public x__VDPClient x__VDP { get; }

        /// <summary>
        /// AI Model resources for MLOps/LLMOps.
        /// </summary>
        public x__ModelClient x__Model { get; }

        /// <summary>
        /// Data orchestration for unified unstructured data representation.
        /// </summary>
        public x__ArtifactClient x__Artifact { get; }

        /// <summary>
        /// Ready-to-use AI applications.
        /// </summary>
        public x__AppClient x__App { get; }

        /// <summary>
        /// Resource usage metrics.
        /// </summary>
        public x__MetricsClient x__Metrics { get; }

        /// <summary>
        /// Pricing plans on Instill Cloud.
        /// </summary>
        public x__SubscriptionClient x__Subscription { get; }

    }
}