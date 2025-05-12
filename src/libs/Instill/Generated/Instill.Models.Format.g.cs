
#nullable enable

namespace Instill
{
    /// <summary>
    /// Format specifies the visual representation of numbers in the column.<br/>
    ///  - FORMAT_PLAIN: Plain number format without any separators or special formatting.<br/>
    ///  - FORMAT_COMMAS: Number format with commas as thousand separators (e.g., 1,234,567).<br/>
    ///  - FORMAT_CURRENCY: Currency format that displays values with a currency symbol.<br/>
    ///  - FORMAT_PERCENTAGE: Percentage format that displays values with a percent symbol.
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// Plain number format without any separators or special formatting.
        /// </summary>
        PLAIN,
        /// <summary>
        /// Number format with commas as thousand separators (e.g., 1,234,567).
        /// </summary>
        COMMAS,
        /// <summary>
        /// Currency format that displays values with a currency symbol.
        /// </summary>
        CURRENCY,
        /// <summary>
        /// Percentage format that displays values with a percent symbol.
        /// </summary>
        PERCENTAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Format value)
        {
            return value switch
            {
                Format.PLAIN => "FORMAT_PLAIN",
                Format.COMMAS => "FORMAT_COMMAS",
                Format.CURRENCY => "FORMAT_CURRENCY",
                Format.PERCENTAGE => "FORMAT_PERCENTAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Format? ToEnum(string value)
        {
            return value switch
            {
                "FORMAT_PLAIN" => Format.PLAIN,
                "FORMAT_COMMAS" => Format.COMMAS,
                "FORMAT_CURRENCY" => Format.CURRENCY,
                "FORMAT_PERCENTAGE" => Format.PERCENTAGE,
                _ => null,
            };
        }
    }
}