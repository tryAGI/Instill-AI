
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetRowResponse contains the requested row.
    /// </summary>
    public sealed partial class GetRowResponse
    {
        /// <summary>
        /// The row resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row")]
        public global::Instill.Row? Row { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRowResponse" /> class.
        /// </summary>
        /// <param name="row">
        /// The row resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRowResponse(
            global::Instill.Row? row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRowResponse" /> class.
        /// </summary>
        public GetRowResponse()
        {
        }
    }
}