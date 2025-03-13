
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATION_TYPE_FILE: file-based citation<br/>
    ///  - CITATION_TYPE_WEB: web-based citation<br/>
    ///  - CITATION_TYPE_TABLE: table-based citation
    /// </summary>
    public enum CitationType
    {
        /// <summary>
        /// file-based citation
        /// </summary>
        FILE,
        /// <summary>
        /// web-based citation
        /// </summary>
        WEB,
        /// <summary>
        /// table-based citation
        /// </summary>
        TABLE,
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
                CitationType.FILE => "CITATION_TYPE_FILE",
                CitationType.WEB => "CITATION_TYPE_WEB",
                CitationType.TABLE => "CITATION_TYPE_TABLE",
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
                "CITATION_TYPE_FILE" => CitationType.FILE,
                "CITATION_TYPE_WEB" => CitationType.WEB,
                "CITATION_TYPE_TABLE" => CitationType.TABLE,
                _ => null,
            };
        }
    }
}