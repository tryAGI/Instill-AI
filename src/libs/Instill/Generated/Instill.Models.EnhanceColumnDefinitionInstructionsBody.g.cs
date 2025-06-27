
#nullable enable

namespace Instill
{
    /// <summary>
    /// EnhanceColumnDefinitionInstructionsRequest represents a request to enhance the instruction of a column definition.
    /// </summary>
    public sealed partial class EnhanceColumnDefinitionInstructionsBody
    {
        /// <summary>
        /// The UID of the column to be enhanced.<br/>
        /// Please provide this field if you want to enhance the instruction of an existing column definition.<br/>
        /// Ignore it if you want to enhance the instruction of a non-created column in the new column creation flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnUid")]
        public string? ColumnUid { get; set; }

        /// <summary>
        /// The column definition to be enhanced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnDefinition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.ColumnDefinition ColumnDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhanceColumnDefinitionInstructionsBody" /> class.
        /// </summary>
        /// <param name="columnUid">
        /// The UID of the column to be enhanced.<br/>
        /// Please provide this field if you want to enhance the instruction of an existing column definition.<br/>
        /// Ignore it if you want to enhance the instruction of a non-created column in the new column creation flow.
        /// </param>
        /// <param name="columnDefinition">
        /// The column definition to be enhanced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhanceColumnDefinitionInstructionsBody(
            global::Instill.ColumnDefinition columnDefinition,
            string? columnUid)
        {
            this.ColumnDefinition = columnDefinition ?? throw new global::System.ArgumentNullException(nameof(columnDefinition));
            this.ColumnUid = columnUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhanceColumnDefinitionInstructionsBody" /> class.
        /// </summary>
        public EnhanceColumnDefinitionInstructionsBody()
        {
        }
    }
}