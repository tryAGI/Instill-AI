
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetModelView
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
    public static class ModelPublicServiceGetModelViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetModelView value)
        {
            return value switch
            {
                ModelPublicServiceGetModelView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceGetModelView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetModelView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetModelView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceGetModelView.ViewFull,
                _ => null,
            };
        }
    }
}