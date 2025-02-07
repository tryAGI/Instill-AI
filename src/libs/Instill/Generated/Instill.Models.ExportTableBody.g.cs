
#nullable enable

namespace Instill
{
    /// <summary>
    /// ExportTableRequest represents a request to export table data.
    /// </summary>
    public sealed partial class ExportTableBody
    {
        /// <summary>
        /// The format to export the data in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ExportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.ExportFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTableBody" /> class.
        /// </summary>
        /// <param name="format">
        /// The format to export the data in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportTableBody(
            global::Instill.ExportFormat format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportTableBody" /> class.
        /// </summary>
        public ExportTableBody()
        {
        }
    }
}