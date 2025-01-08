
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetTableResponse contains the requested table.
    /// </summary>
    public sealed partial class GetTableResponse
    {
        /// <summary>
        /// The table resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        public global::Instill.Table? Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableResponse" /> class.
        /// </summary>
        /// <param name="table">
        /// The table resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTableResponse(
            global::Instill.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableResponse" /> class.
        /// </summary>
        public GetTableResponse()
        {
        }
    }
}