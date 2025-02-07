
#nullable enable

namespace Instill
{
    /// <summary>
    /// ColumnDefinition represents a column definition in a table.
    /// </summary>
    public sealed partial class ColumnDefinition
    {
        /// <summary>
        /// The unique identifier of the column.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnUid")]
        public string? ColumnUid { get; set; }

        /// <summary>
        /// The name of the column.<br/>
        /// The name of the column. If this differs from the key in the ColumnDefinitions map,<br/>
        /// the key will be updated to match this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The order of the column in the table, starting at 1. This determines the column's position<br/>
        /// when displaying or processing table data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition" /> class.
        /// </summary>
        /// <param name="columnUid">
        /// The unique identifier of the column.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The name of the column.<br/>
        /// The name of the column. If this differs from the key in the ColumnDefinitions map,<br/>
        /// the key will be updated to match this value.
        /// </param>
        /// <param name="type">
        /// The type of the column.
        /// </param>
        /// <param name="order">
        /// The order of the column in the table, starting at 1. This determines the column's position<br/>
        /// when displaying or processing table data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColumnDefinition(
            string type,
            int order,
            string? columnUid,
            string? name)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Order = order;
            this.ColumnUid = columnUid;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition" /> class.
        /// </summary>
        public ColumnDefinition()
        {
        }
    }
}