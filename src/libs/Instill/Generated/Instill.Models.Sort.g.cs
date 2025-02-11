
#nullable enable

namespace Instill
{
    /// <summary>
    /// The sort of the column.<br/>
    ///  - SORT_ASCENDING: The sort is ascending.<br/>
    ///  - SORT_DESCENDING: The sort is descending.
    /// </summary>
    public enum Sort
    {
        /// <summary>
        /// The sort is ascending.
        /// </summary>
        ASCENDING,
        /// <summary>
        /// The sort is descending.
        /// </summary>
        DESCENDING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sort value)
        {
            return value switch
            {
                Sort.ASCENDING => "SORT_ASCENDING",
                Sort.DESCENDING => "SORT_DESCENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sort? ToEnum(string value)
        {
            return value switch
            {
                "SORT_ASCENDING" => Sort.ASCENDING,
                "SORT_DESCENDING" => Sort.DESCENDING,
                _ => null,
            };
        }
    }
}