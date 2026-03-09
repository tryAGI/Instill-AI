
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
        /// Full representation with all metadata.
        /// </summary>
        ViewFull,
        /// <summary>
        /// Returns MinIO pre-signed URL to converted summary content.
        /// </summary>
        ViewSummary,
        /// <summary>
        /// Returns MinIO pre-signed URL to converted markdown content.
        /// </summary>
        ViewContent,
        /// <summary>
        /// Returns MinIO pre-signed URL to standardized file:
        /// </summary>
        ViewStandardFileType,
        /// <summary>
        /// Returns MinIO pre-signed URL to the original uploaded file.
        /// </summary>
        ViewOriginalFileType,
        /// <summary>
        /// Returns Gemini cache resource name.
        /// </summary>
        ViewCache,
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
                ArtifactPublicServiceGetFileView.ViewFull => "VIEW_FULL",
                ArtifactPublicServiceGetFileView.ViewSummary => "VIEW_SUMMARY",
                ArtifactPublicServiceGetFileView.ViewContent => "VIEW_CONTENT",
                ArtifactPublicServiceGetFileView.ViewStandardFileType => "VIEW_STANDARD_FILE_TYPE",
                ArtifactPublicServiceGetFileView.ViewOriginalFileType => "VIEW_ORIGINAL_FILE_TYPE",
                ArtifactPublicServiceGetFileView.ViewCache => "VIEW_CACHE",
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
                "VIEW_FULL" => ArtifactPublicServiceGetFileView.ViewFull,
                "VIEW_SUMMARY" => ArtifactPublicServiceGetFileView.ViewSummary,
                "VIEW_CONTENT" => ArtifactPublicServiceGetFileView.ViewContent,
                "VIEW_STANDARD_FILE_TYPE" => ArtifactPublicServiceGetFileView.ViewStandardFileType,
                "VIEW_ORIGINAL_FILE_TYPE" => ArtifactPublicServiceGetFileView.ViewOriginalFileType,
                "VIEW_CACHE" => ArtifactPublicServiceGetFileView.ViewCache,
                _ => null,
            };
        }
    }
}