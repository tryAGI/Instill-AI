
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetColumnDefinitionResponse contains the requested column definition.
    /// </summary>
    public sealed partial class GetColumnDefinitionResponse
    {
        /// <summary>
        /// The column definition.<br/>
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
        /// Initializes a new instance of the <see cref="GetColumnDefinitionResponse" /> class.
        /// </summary>
        /// <param name="columnDefinition">
        /// The column definition.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetColumnDefinitionResponse(
            global::Instill.ColumnDefinition? columnDefinition)
        {
            this.ColumnDefinition = columnDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColumnDefinitionResponse" /> class.
        /// </summary>
        public GetColumnDefinitionResponse()
        {
        }
    }
}