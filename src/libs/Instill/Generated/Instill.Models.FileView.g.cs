
#nullable enable

namespace Instill
{
    /// <summary>
    /// View defines how a file is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic metadata.<br/>
    ///  - VIEW_FULL: Full representation with all metadata.<br/>
    ///  - VIEW_SUMMARY: Returns MinIO pre-signed URL to converted summary content.<br/>
    ///  - VIEW_CONTENT: Returns MinIO pre-signed URL to converted markdown content.<br/>
    ///  - VIEW_STANDARD_FILE_TYPE: Returns MinIO pre-signed URL to standardized file:<br/>
    /// - Documents → PDF<br/>
    /// - Images → PNG<br/>
    /// - Audio → OGG<br/>
    /// - Video → MP4<br/>
    ///  - VIEW_ORIGINAL_FILE_TYPE: Returns MinIO pre-signed URL to the original uploaded file.<br/>
    ///  - VIEW_CACHE: Returns Gemini cache resource name.<br/>
    ///  - VIEW_PATCH: Returns MinIO pre-signed URL to patch.md (user-submitted content patches).
    /// </summary>
    public enum FileView
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
    public static class FileViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileView value)
        {
            return value switch
            {
                FileView.ViewBasic => "VIEW_BASIC",
                FileView.ViewCache => "VIEW_CACHE",
                FileView.ViewContent => "VIEW_CONTENT",
                FileView.ViewFull => "VIEW_FULL",
                FileView.ViewOriginalFileType => "VIEW_ORIGINAL_FILE_TYPE",
                FileView.ViewPatch => "VIEW_PATCH",
                FileView.ViewStandardFileType => "VIEW_STANDARD_FILE_TYPE",
                FileView.ViewSummary => "VIEW_SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => FileView.ViewBasic,
                "VIEW_CACHE" => FileView.ViewCache,
                "VIEW_CONTENT" => FileView.ViewContent,
                "VIEW_FULL" => FileView.ViewFull,
                "VIEW_ORIGINAL_FILE_TYPE" => FileView.ViewOriginalFileType,
                "VIEW_PATCH" => FileView.ViewPatch,
                "VIEW_STANDARD_FILE_TYPE" => FileView.ViewStandardFileType,
                "VIEW_SUMMARY" => FileView.ViewSummary,
                _ => null,
            };
        }
    }
}