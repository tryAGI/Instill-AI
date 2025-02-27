
#nullable enable

namespace Instill
{
    /// <summary>
    /// The transparency of the cell.
    /// </summary>
    public sealed partial class Transparency
    {
        /// <summary>
        /// The text of the transparency.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transparency" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the transparency.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transparency(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transparency" /> class.
        /// </summary>
        public Transparency()
        {
        }
    }
}