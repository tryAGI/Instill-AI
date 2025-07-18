
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListSubscriptionFreeTrialsResponse contains the requested free trials.
    /// </summary>
    public sealed partial class ListSubscriptionFreeTrialsResponse
    {
        /// <summary>
        /// A list of subscription free trials.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeTrials")]
        public global::System.Collections.Generic.IList<global::Instill.SubscriptionFreeTrial>? FreeTrials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionFreeTrialsResponse" /> class.
        /// </summary>
        /// <param name="freeTrials">
        /// A list of subscription free trials.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSubscriptionFreeTrialsResponse(
            global::System.Collections.Generic.IList<global::Instill.SubscriptionFreeTrial>? freeTrials)
        {
            this.FreeTrials = freeTrials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionFreeTrialsResponse" /> class.
        /// </summary>
        public ListSubscriptionFreeTrialsResponse()
        {
        }
    }
}