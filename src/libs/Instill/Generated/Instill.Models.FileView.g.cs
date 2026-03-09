
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
    ///  - VIEW_CACHE: Returns Gemini cache resource name.
    /// </summary>
    public enum FileView
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
                FileView.ViewFull => "VIEW_FULL",
                FileView.ViewSummary => "VIEW_SUMMARY",
                FileView.ViewContent => "VIEW_CONTENT",
                FileView.ViewStandardFileType => "VIEW_STANDARD_FILE_TYPE",
                FileView.ViewOriginalFileType => "VIEW_ORIGINAL_FILE_TYPE",
                FileView.ViewCache => "VIEW_CACHE",
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
                "VIEW_FULL" => FileView.ViewFull,
                "VIEW_SUMMARY" => FileView.ViewSummary,
                "VIEW_CONTENT" => FileView.ViewContent,
                "VIEW_STANDARD_FILE_TYPE" => FileView.ViewStandardFileType,
                "VIEW_ORIGINAL_FILE_TYPE" => FileView.ViewOriginalFileType,
                "VIEW_CACHE" => FileView.ViewCache,
                _ => null,
            };
        }
    }
}