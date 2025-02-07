
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateColumnDefinitionsResponse contains the updated column definitions.
    /// </summary>
    public sealed partial class UpdateColumnDefinitionsResponse
    {
        /// <summary>
        /// The updated column definitions.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateColumnDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="columnDefinitions">
        /// The updated column definitions.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateColumnDefinitionsResponse(
            global::System.Collections.Generic.Dictionary<string, global::Instill.ColumnDefinition>? columnDefinitions)
        {
            this.ColumnDefinitions = columnDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateColumnDefinitionsResponse" /> class.
        /// </summary>
        public UpdateColumnDefinitionsResponse()
        {
        }
    }
}