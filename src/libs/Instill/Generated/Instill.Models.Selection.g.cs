
#nullable enable

namespace Instill
{
    /// <summary>
    /// The selection settings of the column.
    /// </summary>
    public sealed partial class Selection
    {
        /// <summary>
        /// The selection of the column.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.SelectionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.SelectionType Type { get; set; }

        /// <summary>
        /// The options for the selection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Instill.Option>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Selection" /> class.
        /// </summary>
        /// <param name="type">
        /// The selection of the column.
        /// </param>
        /// <param name="options">
        /// The options for the selection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Selection(
            global::Instill.SelectionType type,
            global::System.Collections.Generic.IList<global::Instill.Option>? options)
        {
            this.Type = type;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Selection" /> class.
        /// </summary>
        public Selection()
        {
        }
    }
}