
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
        CHUNKTYPETEXT,
        /// <summary>
        /// Image.
        /// </summary>
        CHUNKTYPEIMAGE,
        /// <summary>
        /// Audio.
        /// </summary>
        CHUNKTYPEAUDIO,
        /// <summary>
        /// Video.
        /// </summary>
        CHUNKTYPEVIDEO,
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
                ChunkType2.CHUNKTYPETEXT => "CHUNK_TYPE_TEXT",
                ChunkType2.CHUNKTYPEIMAGE => "CHUNK_TYPE_IMAGE",
                ChunkType2.CHUNKTYPEAUDIO => "CHUNK_TYPE_AUDIO",
                ChunkType2.CHUNKTYPEVIDEO => "CHUNK_TYPE_VIDEO",
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
                "CHUNK_TYPE_TEXT" => ChunkType2.CHUNKTYPETEXT,
                "CHUNK_TYPE_IMAGE" => ChunkType2.CHUNKTYPEIMAGE,
                "CHUNK_TYPE_AUDIO" => ChunkType2.CHUNKTYPEAUDIO,
                "CHUNK_TYPE_VIDEO" => ChunkType2.CHUNKTYPEVIDEO,
                _ => null,
            };
        }
    }
}