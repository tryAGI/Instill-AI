
#nullable enable

namespace Instill
{
    /// <summary>
    /// View defines how a model definition is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    public enum Modelv1alphaView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
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
    public static class Modelv1alphaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Modelv1alphaView value)
        {
            return value switch
            {
                Modelv1alphaView.VIEWBASIC => "VIEW_BASIC",
                Modelv1alphaView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Modelv1alphaView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => Modelv1alphaView.VIEWBASIC,
                "VIEW_FULL" => Modelv1alphaView.VIEWFULL,
                _ => null,
            };
        }
    }
}