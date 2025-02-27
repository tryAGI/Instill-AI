
#nullable enable

namespace Instill
{
    /// <summary>
    /// The type of the citation.<br/>
    ///  - TYPE_WEB: The type is a url of a web page.<br/>
    ///  - TYPE_FILE: The type is a url of a file resource.<br/>
    ///  - TYPE_TABLE: The type is a url of a table resource.
    /// </summary>
    public enum CitationType
    {
        /// <summary>
        /// The type is a url of a web page.
        /// </summary>
        TYPEWEB,
        /// <summary>
        /// The type is a url of a file resource.
        /// </summary>
        TYPEFILE,
        /// <summary>
        /// The type is a url of a table resource.
        /// </summary>
        TYPETABLE,
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
                CitationType.TYPEWEB => "TYPE_WEB",
                CitationType.TYPEFILE => "TYPE_FILE",
                CitationType.TYPETABLE => "TYPE_TABLE",
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
                "TYPE_WEB" => CitationType.TYPEWEB,
                "TYPE_FILE" => CitationType.TYPEFILE,
                "TYPE_TABLE" => CitationType.TYPETABLE,
                _ => null,
            };
        }
    }
}