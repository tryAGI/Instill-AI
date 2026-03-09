
#nullable enable

namespace Instill
{
    /// <summary>
    /// View defines how a model definition is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).<br/>
    ///  - VIEW_FULL: Full representation.
    /// </summary>
    public enum V1alphaView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1alphaViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1alphaView value)
        {
            return value switch
            {
                V1alphaView.ViewBasic => "VIEW_BASIC",
                V1alphaView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1alphaView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => V1alphaView.ViewBasic,
                "VIEW_FULL" => V1alphaView.ViewFull,
                _ => null,
            };
        }
    }
}