
#nullable enable

namespace Instill
{
    /// <summary>
    /// Enumerates the status types for the user's subscription. Please refer to<br/>
    /// the [Stripe<br/>
    /// documentation](https://docs.stripe.com/billing/subscriptions/overview#subscription-statuses)<br/>
    /// for more details.<br/>
    ///  - STATUS_INCOMPLETE: The customer must do a payment-related action to activate the<br/>
    /// subscription.<br/>
    ///  - STATUS_INCOMPLETE_EXPIRED: The subscription failed to activate because no successful payments were<br/>
    /// registered in time.<br/>
    ///  - STATUS_TRIALING: The subscription is currently in a trial period.<br/>
    ///  - STATUS_ACTIVE: The subscription is in good standing.<br/>
    ///  - STATUS_PAST_DUE: Payment on the latest finalised invoice either failed or wasn’t<br/>
    /// attempted.<br/>
    ///  - STATUS_CANCELED: The subscription was cancelled by either the user or the admins.<br/>
    ///  - STATUS_UNPAID: The latest invoice hasn’t been paid but the subscription remains in<br/>
    /// place.<br/>
    ///  - STATUS_PAUSED: The subscription has ended its trial period without a default payment<br/>
    /// method.
    /// </summary>
    public enum StripeSubscriptionDetailStatus
    {
        /// <summary>
        /// The customer must do a payment-related action to activate the
        /// </summary>
        STATUSINCOMPLETE,
        /// <summary>
        /// The subscription failed to activate because no successful payments were
        /// </summary>
        STATUSINCOMPLETEEXPIRED,
        /// <summary>
        /// The subscription is currently in a trial period.
        /// </summary>
        STATUSTRIALING,
        /// <summary>
        /// The subscription is in good standing.
        /// </summary>
        STATUSACTIVE,
        /// <summary>
        /// Payment on the latest finalised invoice either failed or wasn’t
        /// </summary>
        STATUSPASTDUE,
        /// <summary>
        /// The subscription was cancelled by either the user or the admins.
        /// </summary>
        STATUSCANCELED,
        /// <summary>
        /// The latest invoice hasn’t been paid but the subscription remains in
        /// </summary>
        STATUSUNPAID,
        /// <summary>
        /// The subscription has ended its trial period without a default payment
        /// </summary>
        STATUSPAUSED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StripeSubscriptionDetailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StripeSubscriptionDetailStatus value)
        {
            return value switch
            {
                StripeSubscriptionDetailStatus.STATUSINCOMPLETE => "STATUS_INCOMPLETE",
                StripeSubscriptionDetailStatus.STATUSINCOMPLETEEXPIRED => "STATUS_INCOMPLETE_EXPIRED",
                StripeSubscriptionDetailStatus.STATUSTRIALING => "STATUS_TRIALING",
                StripeSubscriptionDetailStatus.STATUSACTIVE => "STATUS_ACTIVE",
                StripeSubscriptionDetailStatus.STATUSPASTDUE => "STATUS_PAST_DUE",
                StripeSubscriptionDetailStatus.STATUSCANCELED => "STATUS_CANCELED",
                StripeSubscriptionDetailStatus.STATUSUNPAID => "STATUS_UNPAID",
                StripeSubscriptionDetailStatus.STATUSPAUSED => "STATUS_PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StripeSubscriptionDetailStatus? ToEnum(string value)
        {
            return value switch
            {
                "STATUS_INCOMPLETE" => StripeSubscriptionDetailStatus.STATUSINCOMPLETE,
                "STATUS_INCOMPLETE_EXPIRED" => StripeSubscriptionDetailStatus.STATUSINCOMPLETEEXPIRED,
                "STATUS_TRIALING" => StripeSubscriptionDetailStatus.STATUSTRIALING,
                "STATUS_ACTIVE" => StripeSubscriptionDetailStatus.STATUSACTIVE,
                "STATUS_PAST_DUE" => StripeSubscriptionDetailStatus.STATUSPASTDUE,
                "STATUS_CANCELED" => StripeSubscriptionDetailStatus.STATUSCANCELED,
                "STATUS_UNPAID" => StripeSubscriptionDetailStatus.STATUSUNPAID,
                "STATUS_PAUSED" => StripeSubscriptionDetailStatus.STATUSPAUSED,
                _ => null,
            };
        }
    }
}