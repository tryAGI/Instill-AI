
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetModelDefinitionView
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
    public static class ModelPublicServiceGetModelDefinitionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetModelDefinitionView value)
        {
            return value switch
            {
                ModelPublicServiceGetModelDefinitionView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceGetModelDefinitionView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetModelDefinitionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetModelDefinitionView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceGetModelDefinitionView.VIEWFULL,
                _ => null,
            };
        }
    }
}