
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileMediaType describes the media category of a knowledge base file.<br/>
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
        Document,
        /// <summary>
        /// Image.
        /// </summary>
        Image,
        /// <summary>
        /// Audio.
        /// </summary>
        Audio,
        /// <summary>
        /// Video.
        /// </summary>
        Video,
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
                FileMediaType.Document => "FILE_MEDIA_TYPE_DOCUMENT",
                FileMediaType.Image => "FILE_MEDIA_TYPE_IMAGE",
                FileMediaType.Audio => "FILE_MEDIA_TYPE_AUDIO",
                FileMediaType.Video => "FILE_MEDIA_TYPE_VIDEO",
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
                "FILE_MEDIA_TYPE_DOCUMENT" => FileMediaType.Document,
                "FILE_MEDIA_TYPE_IMAGE" => FileMediaType.Image,
                "FILE_MEDIA_TYPE_AUDIO" => FileMediaType.Audio,
                "FILE_MEDIA_TYPE_VIDEO" => FileMediaType.Video,
                _ => null,
            };
        }
    }
}