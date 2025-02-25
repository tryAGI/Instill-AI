
#nullable enable

namespace Instill
{
    /// <summary>
    /// ContentType describes the type of a chunk content.<br/>
    ///  - CONTENT_TYPE_CHUNK: Chunk.<br/>
    ///  - CONTENT_TYPE_SUMMARY: Summary.<br/>
    ///  - CONTENT_TYPE_AUGMENTED: Augmented.
    /// </summary>
    public enum ContentType
    {
        /// <summary>
        /// Chunk.
        /// </summary>
        CHUNK,
        /// <summary>
        /// Summary.
        /// </summary>
        SUMMARY,
        /// <summary>
        /// Augmented.
        /// </summary>
        AUGMENTED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentType value)
        {
            return value switch
            {
                ContentType.CHUNK => "CONTENT_TYPE_CHUNK",
                ContentType.SUMMARY => "CONTENT_TYPE_SUMMARY",
                ContentType.AUGMENTED => "CONTENT_TYPE_AUGMENTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentType? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_TYPE_CHUNK" => ContentType.CHUNK,
                "CONTENT_TYPE_SUMMARY" => ContentType.SUMMARY,
                "CONTENT_TYPE_AUGMENTED" => ContentType.AUGMENTED,
                _ => null,
            };
        }
    }
}