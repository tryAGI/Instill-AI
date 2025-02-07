
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateRowRequest represents a request to update a row.
    /// </summary>
    public sealed partial class UpdateRowBody
    {
        /// <summary>
        /// The new row data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public global::Instill.Row? Row { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowBody" /> class.
        /// </summary>
        /// <param name="row">
        /// The new row data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRowBody(
            global::Instill.Row? row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowBody" /> class.
        /// </summary>
        public UpdateRowBody()
        {
        }
    }
}