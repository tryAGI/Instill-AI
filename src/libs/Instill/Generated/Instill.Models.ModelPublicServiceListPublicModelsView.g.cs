
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceListPublicModelsView
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
    public static class ModelPublicServiceListPublicModelsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListPublicModelsView value)
        {
            return value switch
            {
                ModelPublicServiceListPublicModelsView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceListPublicModelsView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListPublicModelsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceListPublicModelsView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceListPublicModelsView.ViewFull,
                _ => null,
            };
        }
    }
}