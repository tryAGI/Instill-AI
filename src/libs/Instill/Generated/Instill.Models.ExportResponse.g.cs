
#nullable enable

namespace Instill
{
    /// <summary>
    /// ExportResponse is an empty response for exporting table data.
    /// </summary>
    public sealed partial class ExportResponse
    {
        /// <summary>
        /// The exported data.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The exported data.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExportResponse(
            byte[]? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportResponse" /> class.
        /// </summary>
        public ExportResponse()
        {
        }
    }
}