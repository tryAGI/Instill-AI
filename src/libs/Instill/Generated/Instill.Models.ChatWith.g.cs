
#nullable enable

namespace Instill
{
    /// <summary>
    /// - CHAT_WITH_AI_ASSISTANT: chat with ai assistant(default)<br/>
    ///  - CHAT_WITH_AI_AGENT: chat with ai agent
    /// </summary>
    public enum ChatWith
    {
        /// <summary>
        /// chat with ai assistant(default)
        /// </summary>
        AIASSISTANT,
        /// <summary>
        /// chat with ai agent
        /// </summary>
        AIAGENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWithExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWith value)
        {
            return value switch
            {
                ChatWith.AIASSISTANT => "CHAT_WITH_AI_ASSISTANT",
                ChatWith.AIAGENT => "CHAT_WITH_AI_AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWith? ToEnum(string value)
        {
            return value switch
            {
                "CHAT_WITH_AI_ASSISTANT" => ChatWith.AIASSISTANT,
                "CHAT_WITH_AI_AGENT" => ChatWith.AIAGENT,
                _ => null,
            };
        }
    }
}