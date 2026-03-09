
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum MgmtPublicServiceGetUserView
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
    public static class MgmtPublicServiceGetUserViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MgmtPublicServiceGetUserView value)
        {
            return value switch
            {
                MgmtPublicServiceGetUserView.ViewBasic => "VIEW_BASIC",
                MgmtPublicServiceGetUserView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MgmtPublicServiceGetUserView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => MgmtPublicServiceGetUserView.ViewBasic,
                "VIEW_FULL" => MgmtPublicServiceGetUserView.ViewFull,
                _ => null,
            };
        }
    }
}