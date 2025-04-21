
#nullable enable

namespace Instill
{
    /// <summary>
    /// ResetCellResponse is an empty response for resetting a cell.
    /// </summary>
    public sealed partial class ResetCellResponse
    {
        /// <summary>
        /// The updated cell resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cell")]
        public global::Instill.Cell? Cell { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetCellResponse" /> class.
        /// </summary>
        /// <param name="cell">
        /// The updated cell resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResetCellResponse(
            global::Instill.Cell? cell)
        {
            this.Cell = cell;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetCellResponse" /> class.
        /// </summary>
        public ResetCellResponse()
        {
        }
    }
}