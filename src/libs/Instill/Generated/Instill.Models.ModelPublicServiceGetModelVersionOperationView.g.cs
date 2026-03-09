
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetModelVersionOperationView
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
    public static class ModelPublicServiceGetModelVersionOperationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetModelVersionOperationView value)
        {
            return value switch
            {
                ModelPublicServiceGetModelVersionOperationView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceGetModelVersionOperationView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetModelVersionOperationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetModelVersionOperationView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceGetModelVersionOperationView.ViewFull,
                _ => null,
            };
        }
    }
}