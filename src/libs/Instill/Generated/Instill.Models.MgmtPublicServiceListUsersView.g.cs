
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum MgmtPublicServiceListUsersView
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
    public static class MgmtPublicServiceListUsersViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MgmtPublicServiceListUsersView value)
        {
            return value switch
            {
                MgmtPublicServiceListUsersView.ViewBasic => "VIEW_BASIC",
                MgmtPublicServiceListUsersView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MgmtPublicServiceListUsersView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => MgmtPublicServiceListUsersView.ViewBasic,
                "VIEW_FULL" => MgmtPublicServiceListUsersView.ViewFull,
                _ => null,
            };
        }
    }
}