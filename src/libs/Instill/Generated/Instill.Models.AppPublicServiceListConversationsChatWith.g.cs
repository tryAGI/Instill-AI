
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPublicServiceListConversationsChatWith
    {
        /// <summary>
        /// chat with ai assistant(default)
        /// </summary>
        CHATWITHAIASSISTANT,
        /// <summary>
        /// chat with ai agent
        /// </summary>
        CHATWITHAIAGENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPublicServiceListConversationsChatWithExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPublicServiceListConversationsChatWith value)
        {
            return value switch
            {
                AppPublicServiceListConversationsChatWith.CHATWITHAIASSISTANT => "CHAT_WITH_AI_ASSISTANT",
                AppPublicServiceListConversationsChatWith.CHATWITHAIAGENT => "CHAT_WITH_AI_AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPublicServiceListConversationsChatWith? ToEnum(string value)
        {
            return value switch
            {
                "CHAT_WITH_AI_ASSISTANT" => AppPublicServiceListConversationsChatWith.CHATWITHAIASSISTANT,
                "CHAT_WITH_AI_AGENT" => AppPublicServiceListConversationsChatWith.CHATWITHAIAGENT,
                _ => null,
            };
        }
    }
}