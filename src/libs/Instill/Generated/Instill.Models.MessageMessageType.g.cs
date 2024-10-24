
#nullable enable

namespace Instill
{
    /// <summary>
    /// - MESSAGE_TYPE_TEXT: text
    /// </summary>
    public enum MessageMessageType
    {
        /// <summary>
        /// text
        /// </summary>
        MESSAGETYPETEXT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageMessageType value)
        {
            return value switch
            {
                MessageMessageType.MESSAGETYPETEXT => "MESSAGE_TYPE_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageMessageType? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_TYPE_TEXT" => MessageMessageType.MESSAGETYPETEXT,
                _ => null,
            };
        }
    }
}