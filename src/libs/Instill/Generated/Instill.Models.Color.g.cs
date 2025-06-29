
#nullable enable

namespace Instill
{
    /// <summary>
    /// Color represents a color.<br/>
    ///  - COLOR_DEFAULT: Default - #F8F9FC<br/>
    ///  - COLOR_LIGHT_NEUTRAL: Light neutral - #F1F3F9<br/>
    ///  - COLOR_DARK_NEUTRAL: Dark neutral - #3F444D<br/>
    ///  - COLOR_LIGHT_BLUE: Light blue - #F0F5FF<br/>
    ///  - COLOR_DARK_BLUE: Dark blue - #316FED<br/>
    ///  - COLOR_LIGHT_GREEN: Light green - #EAFBF5<br/>
    ///  - COLOR_DARK_GREEN: Dark green - #23956F<br/>
    ///  - COLOR_LIGHT_PURPLE: Light purple - #F8F5FF<br/>
    ///  - COLOR_DARK_PURPLE: Dark purple - #8B55F7<br/>
    ///  - COLOR_LIGHT_YELLOW: Light yellow - #FFF8EB<br/>
    ///  - COLOR_LIGHT_RED: Light red - #FEF1F2
    /// </summary>
    public enum Color
    {
        /// <summary>
        /// Default - #F8F9FC
        /// </summary>
        DEFAULT,
        /// <summary>
        /// Light neutral - #F1F3F9
        /// </summary>
        LIGHTNEUTRAL,
        /// <summary>
        /// Dark neutral - #3F444D
        /// </summary>
        DARKNEUTRAL,
        /// <summary>
        /// Light blue - #F0F5FF
        /// </summary>
        LIGHTBLUE,
        /// <summary>
        /// Dark blue - #316FED
        /// </summary>
        DARKBLUE,
        /// <summary>
        /// Light green - #EAFBF5
        /// </summary>
        LIGHTGREEN,
        /// <summary>
        /// Dark green - #23956F
        /// </summary>
        DARKGREEN,
        /// <summary>
        /// Light purple - #F8F5FF
        /// </summary>
        LIGHTPURPLE,
        /// <summary>
        /// Dark purple - #8B55F7
        /// </summary>
        DARKPURPLE,
        /// <summary>
        /// Light yellow - #FFF8EB
        /// </summary>
        LIGHTYELLOW,
        /// <summary>
        /// Light red - #FEF1F2
        /// </summary>
        LIGHTRED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Color value)
        {
            return value switch
            {
                Color.DEFAULT => "COLOR_DEFAULT",
                Color.LIGHTNEUTRAL => "COLOR_LIGHT_NEUTRAL",
                Color.DARKNEUTRAL => "COLOR_DARK_NEUTRAL",
                Color.LIGHTBLUE => "COLOR_LIGHT_BLUE",
                Color.DARKBLUE => "COLOR_DARK_BLUE",
                Color.LIGHTGREEN => "COLOR_LIGHT_GREEN",
                Color.DARKGREEN => "COLOR_DARK_GREEN",
                Color.LIGHTPURPLE => "COLOR_LIGHT_PURPLE",
                Color.DARKPURPLE => "COLOR_DARK_PURPLE",
                Color.LIGHTYELLOW => "COLOR_LIGHT_YELLOW",
                Color.LIGHTRED => "COLOR_LIGHT_RED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Color? ToEnum(string value)
        {
            return value switch
            {
                "COLOR_DEFAULT" => Color.DEFAULT,
                "COLOR_LIGHT_NEUTRAL" => Color.LIGHTNEUTRAL,
                "COLOR_DARK_NEUTRAL" => Color.DARKNEUTRAL,
                "COLOR_LIGHT_BLUE" => Color.LIGHTBLUE,
                "COLOR_DARK_BLUE" => Color.DARKBLUE,
                "COLOR_LIGHT_GREEN" => Color.LIGHTGREEN,
                "COLOR_DARK_GREEN" => Color.DARKGREEN,
                "COLOR_LIGHT_PURPLE" => Color.LIGHTPURPLE,
                "COLOR_DARK_PURPLE" => Color.DARKPURPLE,
                "COLOR_LIGHT_YELLOW" => Color.LIGHTYELLOW,
                "COLOR_LIGHT_RED" => Color.LIGHTRED,
                _ => null,
            };
        }
    }
}