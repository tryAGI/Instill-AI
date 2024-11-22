
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPublicServiceListAppsAppType
    {
        /// <summary>
        /// AppType is a AI assistant app.
        /// </summary>
        APPTYPEAIASSISTANT,
        /// <summary>
        /// AppType is a AI agent app.
        /// </summary>
        APPTYPEAIAGENT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPublicServiceListAppsAppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPublicServiceListAppsAppType value)
        {
            return value switch
            {
                AppPublicServiceListAppsAppType.APPTYPEAIASSISTANT => "APP_TYPE_AI_ASSISTANT",
                AppPublicServiceListAppsAppType.APPTYPEAIAGENT => "APP_TYPE_AI_AGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPublicServiceListAppsAppType? ToEnum(string value)
        {
            return value switch
            {
                "APP_TYPE_AI_ASSISTANT" => AppPublicServiceListAppsAppType.APPTYPEAIASSISTANT,
                "APP_TYPE_AI_AGENT" => AppPublicServiceListAppsAppType.APPTYPEAIAGENT,
                _ => null,
            };
        }
    }
}