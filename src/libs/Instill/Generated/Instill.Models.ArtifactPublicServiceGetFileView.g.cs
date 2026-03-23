
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArtifactPublicServiceGetFileView
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
    public static class ArtifactPublicServiceGetFileViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactPublicServiceGetFileView value)
        {
            return value switch
            {
                ArtifactPublicServiceGetFileView.ViewBasic => "VIEW_BASIC",
                ArtifactPublicServiceGetFileView.ViewCache => "VIEW_CACHE",
                ArtifactPublicServiceGetFileView.ViewContent => "VIEW_CONTENT",
                ArtifactPublicServiceGetFileView.ViewFull => "VIEW_FULL",
                ArtifactPublicServiceGetFileView.ViewOriginalFileType => "VIEW_ORIGINAL_FILE_TYPE",
                ArtifactPublicServiceGetFileView.ViewPatch => "VIEW_PATCH",
                ArtifactPublicServiceGetFileView.ViewStandardFileType => "VIEW_STANDARD_FILE_TYPE",
                ArtifactPublicServiceGetFileView.ViewSummary => "VIEW_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactPublicServiceGetFileView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ArtifactPublicServiceGetFileView.ViewBasic,
                "VIEW_CACHE" => ArtifactPublicServiceGetFileView.ViewCache,
                "VIEW_CONTENT" => ArtifactPublicServiceGetFileView.ViewContent,
                "VIEW_FULL" => ArtifactPublicServiceGetFileView.ViewFull,
                "VIEW_ORIGINAL_FILE_TYPE" => ArtifactPublicServiceGetFileView.ViewOriginalFileType,
                "VIEW_PATCH" => ArtifactPublicServiceGetFileView.ViewPatch,
                "VIEW_STANDARD_FILE_TYPE" => ArtifactPublicServiceGetFileView.ViewStandardFileType,
                "VIEW_SUMMARY" => ArtifactPublicServiceGetFileView.ViewSummary,
                _ => null,
            };
        }
    }
}