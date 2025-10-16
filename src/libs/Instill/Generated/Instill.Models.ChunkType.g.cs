
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
        /// Content.
        /// </summary>
        TYPECONTENT,
        /// <summary>
        /// Summary.
        /// </summary>
        TYPESUMMARY,
        /// <summary>
        /// Augmented.
        /// </summary>
        TYPEAUGMENTED,
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
                ChunkType.TYPECONTENT => "TYPE_CONTENT",
                ChunkType.TYPESUMMARY => "TYPE_SUMMARY",
                ChunkType.TYPEAUGMENTED => "TYPE_AUGMENTED",
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
                "TYPE_CONTENT" => ChunkType.TYPECONTENT,
                "TYPE_SUMMARY" => ChunkType.TYPESUMMARY,
                "TYPE_AUGMENTED" => ChunkType.TYPEAUGMENTED,
                _ => null,
            };
        }
    }
}