
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateCellRequest represents a request to update a cell.
    /// </summary>
    public sealed partial class UpdateCellBody
    {
        /// <summary>
        /// The new cell data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell")]
        public global::Instill.Cell? Cell { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCellBody" /> class.
        /// </summary>
        /// <param name="cell">
        /// The new cell data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCellBody(
            global::Instill.Cell? cell)
        {
            this.Cell = cell;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCellBody" /> class.
        /// </summary>
        public UpdateCellBody()
        {
        }
    }
}