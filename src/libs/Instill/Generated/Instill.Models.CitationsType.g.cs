
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATIONS_TYPE_CHUNK: Chunk-based citation<br/>
    ///  - CITATIONS_TYPE_URL: URL-based citation
    /// </summary>
    public enum CitationsType
    {
        /// <summary>
        /// Chunk-based citation
        /// </summary>
        CHUNK,
        /// <summary>
        /// URL-based citation
        /// </summary>
        URL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationsType value)
        {
            return value switch
            {
                CitationsType.CHUNK => "CITATIONS_TYPE_CHUNK",
                CitationsType.URL => "CITATIONS_TYPE_URL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationsType? ToEnum(string value)
        {
            return value switch
            {
                "CITATIONS_TYPE_CHUNK" => CitationsType.CHUNK,
                "CITATIONS_TYPE_URL" => CitationsType.URL,
                _ => null,
            };
        }
    }
}