
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
        /// The unique identifier of the row to insert after.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterRowUid")]
        public string? AfterRowUid { get; set; }

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
        /// <param name="afterRowUid">
        /// The unique identifier of the row to insert after.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public InsertRowBody(
            global::Instill.Row? row,
            string? afterRowUid)
        {
            this.Row = row;
            this.AfterRowUid = afterRowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertRowBody" /> class.
        /// </summary>
        public InsertRowBody()
        {
        }
    }
}