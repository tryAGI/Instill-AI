
#nullable enable

namespace Instill
{
    /// <summary>
    /// AppType represents the type of the app.<br/>
    ///  - APP_TYPE_AI_ASSISTANT: AppType is a AI assistant app.<br/>
    ///  - APP_TYPE_AI_AGENT: AppType is a AI agent app.
    /// </summary>
    public enum AppType
    {
        /// <summary>
        /// AppType is a AI assistant app.
        /// </summary>
        AIASSISTANT,
        /// <summary>
        /// AppType is a AI agent app.
        /// </summary>
        AIAGENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppType value)
        {
            return value switch
            {
                AppType.AIASSISTANT => "APP_TYPE_AI_ASSISTANT",
                AppType.AIAGENT => "APP_TYPE_AI_AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppType? ToEnum(string value)
        {
            return value switch
            {
                "APP_TYPE_AI_ASSISTANT" => AppType.AIASSISTANT,
                "APP_TYPE_AI_AGENT" => AppType.AIAGENT,
                _ => null,
            };
        }
    }
}