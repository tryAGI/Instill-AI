
#nullable enable

namespace Instill
{
    /// <summary>
    /// Unit of measurement for a position within a file.<br/>
    ///  - UNIT_CHARACTER: Character positions (for Markdown and other text files).<br/>
    ///  - UNIT_PAGE: Page positions (for documents). For pages, positions are 1-indexed<br/>
    /// (e.g., page 4 of 4) to align with document visualization standards.<br/>
    ///  - UNIT_TIME_MS: Time positions in milliseconds (for audio/video files).<br/>
    ///  - UNIT_PIXEL: Pixel positions (for images and other 2D content).
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// Character positions (for Markdown and other text files).
        /// </summary>
        Character,
        /// <summary>
        /// Page positions (for documents). For pages, positions are 1-indexed
        /// </summary>
        Page,
        /// <summary>
        /// Time positions in milliseconds (for audio/video files).
        /// </summary>
        TimeMs,
        /// <summary>
        /// Pixel positions (for images and other 2D content).
        /// </summary>
        Pixel,
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
                Unit.Character => "UNIT_CHARACTER",
                Unit.Page => "UNIT_PAGE",
                Unit.TimeMs => "UNIT_TIME_MS",
                Unit.Pixel => "UNIT_PIXEL",
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
                "UNIT_CHARACTER" => Unit.Character,
                "UNIT_PAGE" => Unit.Page,
                "UNIT_TIME_MS" => Unit.TimeMs,
                "UNIT_PIXEL" => Unit.Pixel,
                _ => null,
            };
        }
    }
}