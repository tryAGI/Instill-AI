
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
    public enum ChunkType2
    {
        /// <summary>
        /// Text.
        /// </summary>
        ChunkTypeText,
        /// <summary>
        /// Image.
        /// </summary>
        ChunkTypeImage,
        /// <summary>
        /// Audio.
        /// </summary>
        ChunkTypeAudio,
        /// <summary>
        /// Video.
        /// </summary>
        ChunkTypeVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkType2 value)
        {
            return value switch
            {
                ChunkType2.ChunkTypeText => "CHUNK_TYPE_TEXT",
                ChunkType2.ChunkTypeImage => "CHUNK_TYPE_IMAGE",
                ChunkType2.ChunkTypeAudio => "CHUNK_TYPE_AUDIO",
                ChunkType2.ChunkTypeVideo => "CHUNK_TYPE_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkType2? ToEnum(string value)
        {
            return value switch
            {
                "CHUNK_TYPE_TEXT" => ChunkType2.ChunkTypeText,
                "CHUNK_TYPE_IMAGE" => ChunkType2.ChunkTypeImage,
                "CHUNK_TYPE_AUDIO" => ChunkType2.ChunkTypeAudio,
                "CHUNK_TYPE_VIDEO" => ChunkType2.ChunkTypeVideo,
                _ => null,
            };
        }
    }
}