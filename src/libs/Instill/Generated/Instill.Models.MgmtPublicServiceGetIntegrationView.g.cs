
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum MgmtPublicServiceGetIntegrationView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MgmtPublicServiceGetIntegrationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MgmtPublicServiceGetIntegrationView value)
        {
            return value switch
            {
                MgmtPublicServiceGetIntegrationView.ViewBasic => "VIEW_BASIC",
                MgmtPublicServiceGetIntegrationView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MgmtPublicServiceGetIntegrationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => MgmtPublicServiceGetIntegrationView.ViewBasic,
                "VIEW_FULL" => MgmtPublicServiceGetIntegrationView.ViewFull,
                _ => null,
            };
        }
    }
}