
#nullable enable

namespace Instill
{
    /// <summary>
    /// OrganizationSubscription details describe the plan (i.e., features) an organization has access to.
    /// </summary>
    public sealed partial class OrganizationSubscription
    {
        /// <summary>
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.OrganizationSubscriptionPlanJsonConverter))]
        public global::Instill.OrganizationSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::Instill.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Number of used seats within the organization subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedSeats")]
        public int? UsedSeats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}