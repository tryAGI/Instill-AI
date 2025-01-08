
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BooleanCell(
            bool value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanCell" /> class.
        /// </summary>
        public BooleanCell()
        {
        }
    }
}