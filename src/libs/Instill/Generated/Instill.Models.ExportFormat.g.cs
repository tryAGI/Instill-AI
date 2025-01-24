
#nullable enable

namespace Instill
{
    /// <summary>
    /// ExportFormat represents the format to export the data in.<br/>
    ///  - EXPORT_FORMAT_CSV: The format is CSV.<br/>
    ///  - EXPORT_FORMAT_PARQUET: The format is Parquet.
    /// </summary>
    public enum ExportFormat
    {
        /// <summary>
        /// The format is CSV.
        /// </summary>
        CSV,
        /// <summary>
        /// The format is Parquet.
        /// </summary>
        PARQUET,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportFormat value)
        {
            return value switch
            {
                ExportFormat.CSV => "EXPORT_FORMAT_CSV",
                ExportFormat.PARQUET => "EXPORT_FORMAT_PARQUET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "EXPORT_FORMAT_CSV" => ExportFormat.CSV,
                "EXPORT_FORMAT_PARQUET" => ExportFormat.PARQUET,
                _ => null,
            };
        }
    }
}