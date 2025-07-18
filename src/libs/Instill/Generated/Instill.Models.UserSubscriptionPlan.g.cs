
#nullable enable

namespace Instill
{
    /// <summary>
    /// Enumerates the plan types for the user subscription.<br/>
    ///  - PLAN_STARTER: The starter plan is an individual plan for developers and early-stage<br/>
    /// projects. This plan offers a free trial period that doesn't require the<br/>
    /// customer to have a default payment method. After the free trial period<br/>
    /// is over, the subscription state will transition from trialing to paused.
    /// </summary>
    public enum UserSubscriptionPlan
    {
        /// <summary>
        /// The starter plan is an individual plan for developers and early-stage
        /// </summary>
        PLANSTARTER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserSubscriptionPlan value)
        {
            return value switch
            {
                UserSubscriptionPlan.PLANSTARTER => "PLAN_STARTER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "PLAN_STARTER" => UserSubscriptionPlan.PLANSTARTER,
                _ => null,
            };
        }
    }
}