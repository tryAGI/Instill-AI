
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetColumnDefinitionsResponse contains the column definitions.
    /// </summary>
    public sealed partial class GetColumnDefinitionsResponse
    {
        /// <summary>
        /// Map of column names to their definitions.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinitions")]
        public global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? ColumnDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColumnDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="columnDefinitions">
        /// Map of column names to their definitions.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetColumnDefinitionsResponse(
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? columnDefinitions)
        {
            this.ColumnDefinitions = columnDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColumnDefinitionsResponse" /> class.
        /// </summary>
        public GetColumnDefinitionsResponse()
        {
        }
    }
}