
#nullable enable

namespace Instill
{
    /// <summary>
    /// UserSubscription details describe the plan of an individual user (i.e., the<br/>
    /// features they have access to).
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.UserSubscriptionPlanJsonConverter))]
        public global::Instill.UserSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::Instill.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        /// <param name="plan">
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="detail">
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSubscription(
            global::Instill.UserSubscriptionPlan? plan,
            global::Instill.StripeSubscriptionDetail? detail)
        {
            this.Plan = plan;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        public UserSubscription()
        {
        }
    }
}