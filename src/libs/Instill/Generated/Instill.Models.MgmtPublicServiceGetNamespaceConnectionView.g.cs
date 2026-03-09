
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum MgmtPublicServiceGetNamespaceConnectionView
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
    public static class MgmtPublicServiceGetNamespaceConnectionViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MgmtPublicServiceGetNamespaceConnectionView value)
        {
            return value switch
            {
                MgmtPublicServiceGetNamespaceConnectionView.ViewBasic => "VIEW_BASIC",
                MgmtPublicServiceGetNamespaceConnectionView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MgmtPublicServiceGetNamespaceConnectionView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => MgmtPublicServiceGetNamespaceConnectionView.ViewBasic,
                "VIEW_FULL" => MgmtPublicServiceGetNamespaceConnectionView.ViewFull,
                _ => null,
            };
        }
    }
}