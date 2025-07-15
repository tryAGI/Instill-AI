
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetUserSubscriptionAdminResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetUserSubscriptionAdminResponse
    {
        /// <summary>
        /// The subscription resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::Instill.UserSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSubscriptionAdminResponse" /> class.
        /// </summary>
        /// <param name="subscription">
        /// The subscription resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserSubscriptionAdminResponse(
            global::Instill.UserSubscription? subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSubscriptionAdminResponse" /> class.
        /// </summary>
        public GetUserSubscriptionAdminResponse()
        {
        }
    }
}