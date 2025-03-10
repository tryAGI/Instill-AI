
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATION_TYPE_FILE: file-based citation<br/>
    ///  - CITATION_TYPE_WEB: web-based citation<br/>
    ///  - CITATION_TYPE_CELL: cell-based citation
    /// </summary>
    public enum CitationType2
    {
        /// <summary>
        /// file-based citation
        /// </summary>
        CITATIONTYPEFILE,
        /// <summary>
        /// web-based citation
        /// </summary>
        CITATIONTYPEWEB,
        /// <summary>
        /// cell-based citation
        /// </summary>
        CITATIONTYPECELL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationType2 value)
        {
            return value switch
            {
                CitationType2.CITATIONTYPEFILE => "CITATION_TYPE_FILE",
                CitationType2.CITATIONTYPEWEB => "CITATION_TYPE_WEB",
                CitationType2.CITATIONTYPECELL => "CITATION_TYPE_CELL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationType2? ToEnum(string value)
        {
            return value switch
            {
                "CITATION_TYPE_FILE" => CitationType2.CITATIONTYPEFILE,
                "CITATION_TYPE_WEB" => CitationType2.CITATIONTYPEWEB,
                "CITATION_TYPE_CELL" => CitationType2.CITATIONTYPECELL,
                _ => null,
            };
        }
    }
}