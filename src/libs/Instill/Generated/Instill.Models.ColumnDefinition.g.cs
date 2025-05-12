
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Type Type { get; set; }

        /// <summary>
        /// The order of the column in the table, starting at 1. This determines the column's position<br/>
        /// when displaying or processing table data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Order { get; set; }

        /// <summary>
        /// The configuration for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentConfig")]
        public global::Instill.ColumnDefinitionAgentConfig? AgentConfig { get; set; }

        /// <summary>
        /// The sort of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.SortJsonConverter))]
        public global::Instill.Sort? Sort { get; set; }

        /// <summary>
        /// The description for the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Format for number type columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberFormat")]
        public global::Instill.NumberFormat? NumberFormat { get; set; }

        /// <summary>
        /// The selection settings of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        public global::Instill.Selection? Selection { get; set; }

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
        /// <param name="agentConfig">
        /// The configuration for the agent.
        /// </param>
        /// <param name="sort">
        /// The sort of the column.
        /// </param>
        /// <param name="description">
        /// The description for the column.
        /// </param>
        /// <param name="numberFormat">
        /// Format for number type columns.
        /// </param>
        /// <param name="selection">
        /// The selection settings of the column.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColumnDefinition(
            global::Instill.Type type,
            int order,
            string? columnUid,
            string? name,
            global::Instill.ColumnDefinitionAgentConfig? agentConfig,
            global::Instill.Sort? sort,
            string? description,
            global::Instill.NumberFormat? numberFormat,
            global::Instill.Selection? selection)
        {
            this.Type = type;
            this.Order = order;
            this.ColumnUid = columnUid;
            this.Name = name;
            this.AgentConfig = agentConfig;
            this.Sort = sort;
            this.Description = description;
            this.NumberFormat = numberFormat;
            this.Selection = selection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnDefinition" /> class.
        /// </summary>
        public ColumnDefinition()
        {
        }
    }
}