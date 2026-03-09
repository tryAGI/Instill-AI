
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceListPublicModelsVisibility
    {
        /// <summary>
        /// Only the owner can see the model.
        /// </summary>
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the model.
        /// </summary>
        VisibilityPublic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceListPublicModelsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListPublicModelsVisibility value)
        {
            return value switch
            {
                ModelPublicServiceListPublicModelsVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                ModelPublicServiceListPublicModelsVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListPublicModelsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => ModelPublicServiceListPublicModelsVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => ModelPublicServiceListPublicModelsVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}