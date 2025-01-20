
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATION_TYPE_CHUNK: Chunk-based citation<br/>
    ///  - CITATION_TYPE_URL: URL-based citation
    /// </summary>
    public enum CitationType
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
    public static class CitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationType value)
        {
            return value switch
            {
                CitationType.CHUNK => "CITATION_TYPE_CHUNK",
                CitationType.URL => "CITATION_TYPE_URL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationType? ToEnum(string value)
        {
            return value switch
            {
                "CITATION_TYPE_CHUNK" => CitationType.CHUNK,
                "CITATION_TYPE_URL" => CitationType.URL,
                _ => null,
            };
        }
    }
}