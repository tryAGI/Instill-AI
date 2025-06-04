
#nullable enable

namespace Instill
{
    /// <summary>
    /// Enumerates the plan types for the user subscription.<br/>
    ///  - PLAN_FREE: Free plan.<br/>
    ///  - PLAN_STARTER: Starter plan.
    /// </summary>
    public enum UserSubscriptionPlan
    {
        /// <summary>
        /// Free plan.
        /// </summary>
        PLANFREE,
        /// <summary>
        /// Starter plan.
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
                UserSubscriptionPlan.PLANFREE => "PLAN_FREE",
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
                "PLAN_FREE" => UserSubscriptionPlan.PLANFREE,
                "PLAN_STARTER" => UserSubscriptionPlan.PLANSTARTER,
                _ => null,
            };
        }
    }
}