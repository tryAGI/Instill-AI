
#nullable enable

namespace Instill
{
    /// <summary>
    /// NumberCell represents a cell with a number value.
    /// </summary>
    public sealed partial class NumberCell
    {
        /// <summary>
        /// The value of the cell as a number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberCell" /> class.
        /// </summary>
        /// <param name="value">
        /// The value of the cell as a number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberCell(
            double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberCell" /> class.
        /// </summary>
        public NumberCell()
        {
        }
    }
}