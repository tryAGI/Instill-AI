
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionFreeTrial
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.UserSubscriptionPlanJsonConverter))]
        public global::Instill.UserSubscriptionPlan? UserPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.OrganizationSubscriptionPlanJsonConverter))]
        public global::Instill.OrganizationSubscriptionPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The owner's unique identifier. This is the user (customer) that ordered<br/>
        /// the subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// If the subscription is a team plan, the value of this field will be set to<br/>
        /// the organization UID that the subscription is linked to.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationUid")]
        public string? OrganizationUid { get; set; }

        /// <summary>
        /// When the trial ends.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialEnd")]
        public global::System.DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionFreeTrial" /> class.
        /// </summary>
        /// <param name="userPlan"></param>
        /// <param name="organizationPlan"></param>
        /// <param name="ownerUid">
        /// The owner's unique identifier. This is the user (customer) that ordered<br/>
        /// the subscription.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organizationUid">
        /// If the subscription is a team plan, the value of this field will be set to<br/>
        /// the organization UID that the subscription is linked to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="trialEnd">
        /// When the trial ends.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionFreeTrial(
            global::Instill.UserSubscriptionPlan? userPlan,
            global::Instill.OrganizationSubscriptionPlan? organizationPlan,
            string? ownerUid,
            string? organizationUid,
            global::System.DateTime? trialEnd)
        {
            this.UserPlan = userPlan;
            this.OrganizationPlan = organizationPlan;
            this.OwnerUid = ownerUid;
            this.OrganizationUid = organizationUid;
            this.TrialEnd = trialEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionFreeTrial" /> class.
        /// </summary>
        public SubscriptionFreeTrial()
        {
        }
    }
}