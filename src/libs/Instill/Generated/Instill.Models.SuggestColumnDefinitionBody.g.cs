
#nullable enable

namespace Instill
{
    /// <summary>
    /// SuggestColumnDefinitionRequest represents a request to suggest a column definition.
    /// </summary>
    public sealed partial class SuggestColumnDefinitionBody
    {
        /// <summary>
        /// The name of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the column.<br/>
        /// If not provided, the agent will suggest the type.<br/>
        /// If provided, the agent will use this value as the type setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.TypeJsonConverter))]
        public global::Instill.Type? Type { get; set; }

        /// <summary>
        /// The selection settings of the column.<br/>
        /// If not provided, the agent will suggest the selection.<br/>
        /// If provided, the agent will use this value as the selection setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        public global::Instill.Selection? Selection { get; set; }

        /// <summary>
        /// Whether to enable automatic computation for the column.<br/>
        /// If not provided, the agent will suggest whether to enable it or not.<br/>
        /// If provided, the agent will use this value as the enable_automatic_computation setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAutomaticComputation")]
        public bool? EnableAutomaticComputation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the column.
        /// </param>
        /// <param name="type">
        /// The type of the column.<br/>
        /// If not provided, the agent will suggest the type.<br/>
        /// If provided, the agent will use this value as the type setting.
        /// </param>
        /// <param name="selection">
        /// The selection settings of the column.<br/>
        /// If not provided, the agent will suggest the selection.<br/>
        /// If provided, the agent will use this value as the selection setting.
        /// </param>
        /// <param name="enableAutomaticComputation">
        /// Whether to enable automatic computation for the column.<br/>
        /// If not provided, the agent will suggest whether to enable it or not.<br/>
        /// If provided, the agent will use this value as the enable_automatic_computation setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestColumnDefinitionBody(
            string name,
            global::Instill.Type? type,
            global::Instill.Selection? selection,
            bool? enableAutomaticComputation)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Selection = selection;
            this.EnableAutomaticComputation = enableAutomaticComputation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionBody" /> class.
        /// </summary>
        public SuggestColumnDefinitionBody()
        {
        }
    }
}