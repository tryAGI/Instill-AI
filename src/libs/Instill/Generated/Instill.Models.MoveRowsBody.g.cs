
#nullable enable

namespace Instill
{
    /// <summary>
    /// MoveRowsRequest represents a request to move multiple rows.
    /// </summary>
    public sealed partial class MoveRowsBody
    {
        /// <summary>
        /// The unique identifiers of the rows to be moved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowUids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RowUids { get; set; }

        /// <summary>
        /// The unique identifier of the row to move after.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterRowUid")]
        public string? AfterRowUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveRowsBody" /> class.
        /// </summary>
        /// <param name="rowUids">
        /// The unique identifiers of the rows to be moved.
        /// </param>
        /// <param name="afterRowUid">
        /// The unique identifier of the row to move after.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MoveRowsBody(
            global::System.Collections.Generic.IList<string> rowUids,
            string? afterRowUid)
        {
            this.RowUids = rowUids ?? throw new global::System.ArgumentNullException(nameof(rowUids));
            this.AfterRowUid = afterRowUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveRowsBody" /> class.
        /// </summary>
        public MoveRowsBody()
        {
        }
    }
}