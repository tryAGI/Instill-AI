
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileMediaType describes the type of a catalog file.<br/>
    ///  - FILE_MEDIA_TYPE_DOCUMENT: Document.<br/>
    ///  - FILE_MEDIA_TYPE_IMAGE: Image.<br/>
    ///  - FILE_MEDIA_TYPE_AUDIO: Audio.<br/>
    ///  - FILE_MEDIA_TYPE_VIDEO: Video.
    /// </summary>
    public enum FileMediaType
    {
        /// <summary>
        /// Document.
        /// </summary>
        DOCUMENT,
        /// <summary>
        /// Image.
        /// </summary>
        IMAGE,
        /// <summary>
        /// Audio.
        /// </summary>
        AUDIO,
        /// <summary>
        /// Video.
        /// </summary>
        VIDEO,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileMediaType value)
        {
            return value switch
            {
                FileMediaType.DOCUMENT => "FILE_MEDIA_TYPE_DOCUMENT",
                FileMediaType.IMAGE => "FILE_MEDIA_TYPE_IMAGE",
                FileMediaType.AUDIO => "FILE_MEDIA_TYPE_AUDIO",
                FileMediaType.VIDEO => "FILE_MEDIA_TYPE_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileMediaType? ToEnum(string value)
        {
            return value switch
            {
                "FILE_MEDIA_TYPE_DOCUMENT" => FileMediaType.DOCUMENT,
                "FILE_MEDIA_TYPE_IMAGE" => FileMediaType.IMAGE,
                "FILE_MEDIA_TYPE_AUDIO" => FileMediaType.AUDIO,
                "FILE_MEDIA_TYPE_VIDEO" => FileMediaType.VIDEO,
                _ => null,
            };
        }
    }
}