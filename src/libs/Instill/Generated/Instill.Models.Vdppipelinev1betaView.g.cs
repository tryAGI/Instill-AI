
#nullable enable

namespace Instill
{
    /// <summary>
    /// View defines how a resource is presented. Most resources can share this view<br/>
    /// definition, the particular meaning of each value should be defined in the<br/>
    /// resource itself. Certain resources might have their own View definition if<br/>
    /// they need to implement more than 2 (basic / full) views.<br/>
    ///  - VIEW_BASIC: Default view.<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    public enum Vdppipelinev1betaView
    {
        /// <summary>
        /// Default view.
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Vdppipelinev1betaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Vdppipelinev1betaView value)
        {
            return value switch
            {
                Vdppipelinev1betaView.VIEWBASIC => "VIEW_BASIC",
                Vdppipelinev1betaView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Vdppipelinev1betaView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => Vdppipelinev1betaView.VIEWBASIC,
                "VIEW_FULL" => Vdppipelinev1betaView.VIEWFULL,
                _ => null,
            };
        }
    }
}