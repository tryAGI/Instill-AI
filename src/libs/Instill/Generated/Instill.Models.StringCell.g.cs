
#nullable enable

namespace Instill
{
    /// <summary>
    /// StringCell represents a cell with a string value.
    /// </summary>
    public sealed partial class StringCell
    {
        /// <summary>
        /// The value of the cell as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringCell" /> class.
        /// </summary>
        /// <param name="value">
        /// The value of the cell as a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringCell(
            string value)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringCell" /> class.
        /// </summary>
        public StringCell()
        {
        }
    }
}