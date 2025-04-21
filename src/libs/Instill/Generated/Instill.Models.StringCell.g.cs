
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
        /// The value of the cell that directly set by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userInput")]
        public string? UserInput { get; set; }

        /// <summary>
        /// The value of the cell that was computed by the automatic computation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computedValue")]
        public string? ComputedValue { get; set; }

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
        /// <param name="userInput">
        /// The value of the cell that directly set by the user.
        /// </param>
        /// <param name="computedValue">
        /// The value of the cell that was computed by the automatic computation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringCell(
            string value,
            string? userInput,
            string? computedValue)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.UserInput = userInput;
            this.ComputedValue = computedValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringCell" /> class.
        /// </summary>
        public StringCell()
        {
        }
    }
}