
#nullable enable

namespace Instill
{
    /// <summary>
    /// ChunkType contains the different types of a chunk.<br/>
    ///  - CHUNK_TYPE_TEXT: Text.<br/>
    ///  - CHUNK_TYPE_IMAGE: Image.<br/>
    ///  - CHUNK_TYPE_AUDIO: Audio.<br/>
    ///  - CHUNK_TYPE_VIDEO: Video.
    /// </summary>
    public enum ChunkType
    {
        /// <summary>
        /// Text.
        /// </summary>
        TEXT,
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
    public static class ChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkType value)
        {
            return value switch
            {
                ChunkType.TEXT => "CHUNK_TYPE_TEXT",
                ChunkType.IMAGE => "CHUNK_TYPE_IMAGE",
                ChunkType.AUDIO => "CHUNK_TYPE_AUDIO",
                ChunkType.VIDEO => "CHUNK_TYPE_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkType? ToEnum(string value)
        {
            return value switch
            {
                "CHUNK_TYPE_TEXT" => ChunkType.TEXT,
                "CHUNK_TYPE_IMAGE" => ChunkType.IMAGE,
                "CHUNK_TYPE_AUDIO" => ChunkType.AUDIO,
                "CHUNK_TYPE_VIDEO" => ChunkType.VIDEO,
                _ => null,
            };
        }
    }
}