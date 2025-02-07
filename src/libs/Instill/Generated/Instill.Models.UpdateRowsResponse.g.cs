
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateRowsResponse contains the updated rows.
    /// </summary>
    public sealed partial class UpdateRowsResponse
    {
        /// <summary>
        /// The updated row resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::Instill.Row>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowsResponse" /> class.
        /// </summary>
        /// <param name="rows">
        /// The updated row resources.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRowsResponse(
            global::System.Collections.Generic.IList<global::Instill.Row>? rows)
        {
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowsResponse" /> class.
        /// </summary>
        public UpdateRowsResponse()
        {
        }
    }
}