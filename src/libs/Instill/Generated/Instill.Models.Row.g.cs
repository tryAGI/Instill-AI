
#nullable enable

namespace Instill
{
    /// <summary>
    /// Row represents a row in a table.
    /// </summary>
    public sealed partial class Row
    {
        /// <summary>
        /// The unique identifier of the row.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Map of column names to their cell values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Instill.Cell> Cells { get; set; }

        /// <summary>
        /// The timestamp when the row was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// The timestamp when the row was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the row.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cells">
        /// Map of column names to their cell values.
        /// </param>
        /// <param name="createTime">
        /// The timestamp when the row was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The timestamp when the row was last updated.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Row(
            global::System.Collections.Generic.Dictionary<string, global::Instill.Cell> cells,
            string? uid,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.Cells = cells ?? throw new global::System.ArgumentNullException(nameof(cells));
            this.Uid = uid;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row" /> class.
        /// </summary>
        public Row()
        {
        }
    }
}