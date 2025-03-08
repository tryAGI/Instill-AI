
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CITATION_TYPE_FILE: file citation<br/>
    ///  - CITATION_TYPE_URL: URL-based citation<br/>
    ///  - CITATION_TYPE_CELL: cell-based citation
    /// </summary>
    public enum CitationType2
    {
        /// <summary>
        /// file citation
        /// </summary>
        CITATIONTYPEFILE,
        /// <summary>
        /// URL-based citation
        /// </summary>
        CITATIONTYPEURL,
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
                CitationType2.CITATIONTYPEURL => "CITATION_TYPE_URL",
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
                "CITATION_TYPE_URL" => CitationType2.CITATIONTYPEURL,
                "CITATION_TYPE_CELL" => CitationType2.CITATIONTYPECELL,
                _ => null,
            };
        }
    }
}