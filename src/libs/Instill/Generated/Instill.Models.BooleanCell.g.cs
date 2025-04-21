
#nullable enable

namespace Instill
{
    /// <summary>
    /// BooleanCell represents a cell with a boolean value.
    /// </summary>
    public sealed partial class BooleanCell
    {
        /// <summary>
        /// The value of the cell as a boolean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Value { get; set; }

        /// <summary>
        /// The value of the cell that directly set by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userInput")]
        public bool? UserInput { get; set; }

        /// <summary>
        /// The value of the cell that was computed by the automatic computation.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("computedValue")]
        public bool? ComputedValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanCell" /> class.
        /// </summary>
        /// <param name="value">
        /// The value of the cell as a boolean.
        /// </param>
        /// <param name="userInput">
        /// The value of the cell that directly set by the user.
        /// </param>
        /// <param name="computedValue">
        /// The value of the cell that was computed by the automatic computation.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BooleanCell(
            bool value,
            bool? userInput,
            bool? computedValue)
        {
            this.Value = value;
            this.UserInput = userInput;
            this.ComputedValue = computedValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanCell" /> class.
        /// </summary>
        public BooleanCell()
        {
        }
    }
}