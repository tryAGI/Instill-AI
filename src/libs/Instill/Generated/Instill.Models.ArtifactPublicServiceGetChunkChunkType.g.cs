
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArtifactPublicServiceGetChunkChunkType
    {
        /// <summary>
        /// Augmented.
        /// </summary>
        TypeAugmented,
        /// <summary>
        /// Content.
        /// </summary>
        TypeContent,
        /// <summary>
        /// Summary.
        /// </summary>
        TypeSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactPublicServiceGetChunkChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactPublicServiceGetChunkChunkType value)
        {
            return value switch
            {
                ArtifactPublicServiceGetChunkChunkType.TypeAugmented => "TYPE_AUGMENTED",
                ArtifactPublicServiceGetChunkChunkType.TypeContent => "TYPE_CONTENT",
                ArtifactPublicServiceGetChunkChunkType.TypeSummary => "TYPE_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactPublicServiceGetChunkChunkType? ToEnum(string value)
        {
            return value switch
            {
                "TYPE_AUGMENTED" => ArtifactPublicServiceGetChunkChunkType.TypeAugmented,
                "TYPE_CONTENT" => ArtifactPublicServiceGetChunkChunkType.TypeContent,
                "TYPE_SUMMARY" => ArtifactPublicServiceGetChunkChunkType.TypeSummary,
                _ => null,
            };
        }
    }
}