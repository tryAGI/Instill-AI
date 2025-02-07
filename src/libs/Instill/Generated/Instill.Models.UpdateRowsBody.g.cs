
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateRowsRequest represents a request to update multiple rows.
    /// </summary>
    public sealed partial class UpdateRowsBody
    {
        /// <summary>
        /// The rows to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::Instill.Row>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowsBody" /> class.
        /// </summary>
        /// <param name="rows">
        /// The rows to update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRowsBody(
            global::System.Collections.Generic.IList<global::Instill.Row>? rows)
        {
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowsBody" /> class.
        /// </summary>
        public UpdateRowsBody()
        {
        }
    }
}