
#nullable enable

namespace Instill
{
    /// <summary>
    /// The type of the column.<br/>
    ///  - TYPE_STRING: The type is a string.<br/>
    ///  - TYPE_NUMBER: The type is a number.<br/>
    ///  - TYPE_BOOLEAN: The type is a boolean.<br/>
    ///  - TYPE_FILE: The type is a url of a file resource.
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// The type is a string.
        /// </summary>
        STRING,
        /// <summary>
        /// The type is a number.
        /// </summary>
        NUMBER,
        /// <summary>
        /// The type is a boolean.
        /// </summary>
        BOOLEAN,
        /// <summary>
        /// The type is a url of a file resource.
        /// </summary>
        FILE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type value)
        {
            return value switch
            {
                Type.STRING => "TYPE_STRING",
                Type.NUMBER => "TYPE_NUMBER",
                Type.BOOLEAN => "TYPE_BOOLEAN",
                Type.FILE => "TYPE_FILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type? ToEnum(string value)
        {
            return value switch
            {
                "TYPE_STRING" => Type.STRING,
                "TYPE_NUMBER" => Type.NUMBER,
                "TYPE_BOOLEAN" => Type.BOOLEAN,
                "TYPE_FILE" => Type.FILE,
                _ => null,
            };
        }
    }
}