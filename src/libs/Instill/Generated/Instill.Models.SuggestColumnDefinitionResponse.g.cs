
#nullable enable

namespace Instill
{
    /// <summary>
    /// SuggestColumnDefinitionResponse represents a response to a request to suggest a column definition.
    /// </summary>
    public sealed partial class SuggestColumnDefinitionResponse
    {
        /// <summary>
        /// The suggested column definition.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinition")]
        public global::Instill.ColumnDefinition? ColumnDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionResponse" /> class.
        /// </summary>
        /// <param name="columnDefinition">
        /// The suggested column definition.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestColumnDefinitionResponse(
            global::Instill.ColumnDefinition? columnDefinition)
        {
            this.ColumnDefinition = columnDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestColumnDefinitionResponse" /> class.
        /// </summary>
        public SuggestColumnDefinitionResponse()
        {
        }
    }
}