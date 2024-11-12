
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetOrganizationSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetOrganizationSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::Instill.OrganizationSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="subscription">
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetOrganizationSubscriptionResponse(
            global::Instill.OrganizationSubscription? subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationSubscriptionResponse" /> class.
        /// </summary>
        public GetOrganizationSubscriptionResponse()
        {
        }
    }
}