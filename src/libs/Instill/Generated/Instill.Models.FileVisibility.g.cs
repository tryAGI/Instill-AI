
#nullable enable

namespace Instill
{
    /// <summary>
    /// Visibility defines who can discover and access the file.<br/>
    ///  - VISIBILITY_PRIVATE: Reserved for future: truly private (only creator + invited users).<br/>
    ///  - VISIBILITY_PUBLIC: Discoverable by anyone, including anonymous visitors.<br/>
    ///  - VISIBILITY_WORKSPACE: Org members can access via all-members grant. Default for files.<br/>
    ///  - VISIBILITY_LINK_SHARED: Anyone with the share link (/r/{token}) can access via capability token.
    /// </summary>
    public enum FileVisibility
    {
        /// <summary>
        /// Anyone with the share link (/r/{token}) can access via capability token.
        /// </summary>
        VisibilityLinkShared,
        /// <summary>
        /// Reserved for future: truly private (only creator + invited users).
        /// </summary>
        VisibilityPrivate,
        /// <summary>
        /// Discoverable by anyone, including anonymous visitors.
        /// </summary>
        VisibilityPublic,
        /// <summary>
        /// Org members can access via all-members grant. Default for files.
        /// </summary>
        VisibilityWorkspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileVisibility value)
        {
            return value switch
            {
                FileVisibility.VisibilityLinkShared => "VISIBILITY_LINK_SHARED",
                FileVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                FileVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                FileVisibility.VisibilityWorkspace => "VISIBILITY_WORKSPACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_LINK_SHARED" => FileVisibility.VisibilityLinkShared,
                "VISIBILITY_PRIVATE" => FileVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => FileVisibility.VisibilityPublic,
                "VISIBILITY_WORKSPACE" => FileVisibility.VisibilityWorkspace,
                _ => null,
            };
        }
    }
}