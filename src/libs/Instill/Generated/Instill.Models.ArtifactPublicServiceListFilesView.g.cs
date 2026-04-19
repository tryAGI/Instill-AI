
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArtifactPublicServiceListFilesView
    {
        /// <summary>
        /// Default view, only includes basic metadata.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Returns Gemini cache resource name.
        /// </summary>
        ViewCache,
        /// <summary>
        /// Returns MinIO pre-signed URL to converted markdown content.
        /// </summary>
        ViewContent,
        /// <summary>
        /// Full representation with all metadata.
        /// </summary>
        ViewFull,
        /// <summary>
        /// Returns MinIO pre-signed URL to the original uploaded file.
        /// </summary>
        ViewOriginalFileType,
        /// <summary>
        /// Returns MinIO pre-signed URL to patch.md (user-submitted content patches).
        /// </summary>
        ViewPatch,
        /// <summary>
        /// Returns MinIO pre-signed URL to standardized file:
        /// </summary>
        ViewStandardFileType,
        /// <summary>
        /// Returns MinIO pre-signed URL to converted summary content.
        /// </summary>
        ViewSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactPublicServiceListFilesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactPublicServiceListFilesView value)
        {
            return value switch
            {
                ArtifactPublicServiceListFilesView.ViewBasic => "VIEW_BASIC",
                ArtifactPublicServiceListFilesView.ViewCache => "VIEW_CACHE",
                ArtifactPublicServiceListFilesView.ViewContent => "VIEW_CONTENT",
                ArtifactPublicServiceListFilesView.ViewFull => "VIEW_FULL",
                ArtifactPublicServiceListFilesView.ViewOriginalFileType => "VIEW_ORIGINAL_FILE_TYPE",
                ArtifactPublicServiceListFilesView.ViewPatch => "VIEW_PATCH",
                ArtifactPublicServiceListFilesView.ViewStandardFileType => "VIEW_STANDARD_FILE_TYPE",
                ArtifactPublicServiceListFilesView.ViewSummary => "VIEW_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactPublicServiceListFilesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ArtifactPublicServiceListFilesView.ViewBasic,
                "VIEW_CACHE" => ArtifactPublicServiceListFilesView.ViewCache,
                "VIEW_CONTENT" => ArtifactPublicServiceListFilesView.ViewContent,
                "VIEW_FULL" => ArtifactPublicServiceListFilesView.ViewFull,
                "VIEW_ORIGINAL_FILE_TYPE" => ArtifactPublicServiceListFilesView.ViewOriginalFileType,
                "VIEW_PATCH" => ArtifactPublicServiceListFilesView.ViewPatch,
                "VIEW_STANDARD_FILE_TYPE" => ArtifactPublicServiceListFilesView.ViewStandardFileType,
                "VIEW_SUMMARY" => ArtifactPublicServiceListFilesView.ViewSummary,
                _ => null,
            };
        }
    }
}