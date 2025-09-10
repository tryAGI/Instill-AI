
#nullable enable

namespace Instill
{
    /// <summary>
    /// Unit of measurement for a position within a file.<br/>
    ///  - UNIT_CHARACTER: Character positions (for Markdown and other text files).<br/>
    ///  - UNIT_PAGE: Page positions (for documents).<br/>
    ///  - UNIT_TIME_MS: Time positions in milliseconds (for audio/video files).<br/>
    ///  - UNIT_PIXEL: Pixel positions (for images and other 2D content).
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// Character positions (for Markdown and other text files).
        /// </summary>
        CHARACTER,
        /// <summary>
        /// Page positions (for documents).
        /// </summary>
        PAGE,
        /// <summary>
        /// Time positions in milliseconds (for audio/video files).
        /// </summary>
        TIMEMS,
        /// <summary>
        /// Pixel positions (for images and other 2D content).
        /// </summary>
        PIXEL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Unit value)
        {
            return value switch
            {
                Unit.CHARACTER => "UNIT_CHARACTER",
                Unit.PAGE => "UNIT_PAGE",
                Unit.TIMEMS => "UNIT_TIME_MS",
                Unit.PIXEL => "UNIT_PIXEL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Unit? ToEnum(string value)
        {
            return value switch
            {
                "UNIT_CHARACTER" => Unit.CHARACTER,
                "UNIT_PAGE" => Unit.PAGE,
                "UNIT_TIME_MS" => Unit.TIMEMS,
                "UNIT_PIXEL" => Unit.PIXEL,
                _ => null,
            };
        }
    }
}