
#nullable enable

namespace Instill
{
    /// <summary>
    /// Enumerates the plan types for the organization subscription.<br/>
    ///  - PLAN_TEAM: The team plan is a subscription that offers collaboration features for<br/>
    /// small teams.<br/>
    ///  - PLAN_ENTERPRISE: The enterprise plan is a subscription for large teams and/or high-volume<br/>
    /// deployments. This kind of subscription doesn't contain Stripe<br/>
    /// subscription details.
    /// </summary>
    public enum OrganizationSubscriptionPlan
    {
        /// <summary>
        /// The team plan is a subscription that offers collaboration features for
        /// </summary>
        PLANTEAM,
        /// <summary>
        /// The enterprise plan is a subscription for large teams and/or high-volume
        /// </summary>
        PLANENTERPRISE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationSubscriptionPlan.PLANTEAM => "PLAN_TEAM",
                OrganizationSubscriptionPlan.PLANENTERPRISE => "PLAN_ENTERPRISE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "PLAN_TEAM" => OrganizationSubscriptionPlan.PLANTEAM,
                "PLAN_ENTERPRISE" => OrganizationSubscriptionPlan.PLANENTERPRISE,
                _ => null,
            };
        }
    }
}