
#nullable enable

namespace Instill
{
    /// <summary>
    /// NumberFormat defines the display format for number type columns.
    /// </summary>
    public sealed partial class NumberFormat
    {
        /// <summary>
        /// The specific format to apply to numbers in this column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Format Format { get; set; }

        /// <summary>
        /// Number of decimal places to display (e.g., 2 would show 1.23).<br/>
        /// If not specified, a default appropriate to the format will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// ISO 4217 currency code (e.g., "USD", "EUR", "JPY") for currency format.<br/>
        /// Required when format is FORMAT_CURRENCY, ignored for other formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFormat" /> class.
        /// </summary>
        /// <param name="format">
        /// The specific format to apply to numbers in this column.
        /// </param>
        /// <param name="decimalPlaces">
        /// Number of decimal places to display (e.g., 2 would show 1.23).<br/>
        /// If not specified, a default appropriate to the format will be used.
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code (e.g., "USD", "EUR", "JPY") for currency format.<br/>
        /// Required when format is FORMAT_CURRENCY, ignored for other formats.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberFormat(
            global::Instill.Format format,
            int? decimalPlaces,
            string? currencyCode)
        {
            this.Format = format;
            this.DecimalPlaces = decimalPlaces;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFormat" /> class.
        /// </summary>
        public NumberFormat()
        {
        }
    }
}