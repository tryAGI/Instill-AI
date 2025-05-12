
#nullable enable

namespace Instill
{
    /// <summary>
    /// The type of the selection.<br/>
    ///  - SELECTION_TYPE_NONE: No selection.<br/>
    ///  - SELECTION_TYPE_SINGLE: The selection is a single value.
    /// </summary>
    public enum SelectionType
    {
        /// <summary>
        /// No selection.
        /// </summary>
        NONE,
        /// <summary>
        /// The selection is a single value.
        /// </summary>
        SINGLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectionType value)
        {
            return value switch
            {
                SelectionType.NONE => "SELECTION_TYPE_NONE",
                SelectionType.SINGLE => "SELECTION_TYPE_SINGLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectionType? ToEnum(string value)
        {
            return value switch
            {
                "SELECTION_TYPE_NONE" => SelectionType.NONE,
                "SELECTION_TYPE_SINGLE" => SelectionType.SINGLE,
                _ => null,
            };
        }
    }
}