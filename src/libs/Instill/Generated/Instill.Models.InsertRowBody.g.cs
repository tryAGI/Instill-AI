
#nullable enable

namespace Instill
{
    /// <summary>
    /// InsertRowRequest represents a request to insert a row into a table.
    /// </summary>
    public sealed partial class InsertRowBody
    {
        /// <summary>
        /// The rows to insert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public global::Instill.Row? Row { get; set; }

        /// <summary>
        /// The unique identifier of the row to insert before.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeRowUid")]
        public string? BeforeRowUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertRowBody" /> class.
        /// </summary>
        /// <param name="row">
        /// The rows to insert.
        /// </param>
        /// <param name="beforeRowUid">
        /// The unique identifier of the row to insert before.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InsertRowBody(
            global::Instill.Row? row,
            string? beforeRowUid)
        {
            this.Row = row;
            this.BeforeRowUid = beforeRowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertRowBody" /> class.
        /// </summary>
        public InsertRowBody()
        {
        }
    }
}