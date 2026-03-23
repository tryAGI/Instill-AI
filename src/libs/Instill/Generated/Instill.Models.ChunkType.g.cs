
#nullable enable

namespace Instill
{
    /// <summary>
    /// Type describes the type of a chunk content.<br/>
    ///  - TYPE_CONTENT: Content.<br/>
    ///  - TYPE_SUMMARY: Summary.<br/>
    ///  - TYPE_AUGMENTED: Augmented.
    /// </summary>
    public enum ChunkType
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
    public static class ChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkType value)
        {
            return value switch
            {
                ChunkType.TypeAugmented => "TYPE_AUGMENTED",
                ChunkType.TypeContent => "TYPE_CONTENT",
                ChunkType.TypeSummary => "TYPE_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkType? ToEnum(string value)
        {
            return value switch
            {
                "TYPE_AUGMENTED" => ChunkType.TypeAugmented,
                "TYPE_CONTENT" => ChunkType.TypeContent,
                "TYPE_SUMMARY" => ChunkType.TypeSummary,
                _ => null,
            };
        }
    }
}