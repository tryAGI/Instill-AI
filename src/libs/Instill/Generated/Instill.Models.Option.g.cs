
#nullable enable

namespace Instill
{
    /// <summary>
    /// An option for the selection.
    /// </summary>
    public sealed partial class Option
    {
        /// <summary>
        /// The value of the cell as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// The value of the cell as a number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberValue")]
        public float? NumberValue { get; set; }

        /// <summary>
        /// Display color of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Option" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// The value of the cell as a string.
        /// </param>
        /// <param name="numberValue">
        /// The value of the cell as a number.
        /// </param>
        /// <param name="color">
        /// Display color of the option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Option(
            string? stringValue,
            float? numberValue,
            string? color)
        {
            this.StringValue = stringValue;
            this.NumberValue = numberValue;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Option" /> class.
        /// </summary>
        public Option()
        {
        }
    }
}