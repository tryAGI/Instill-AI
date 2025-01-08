
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateTableResponse contains the updated table.
    /// </summary>
    public sealed partial class UpdateTableResponse
    {
        /// <summary>
        /// The updated table resource.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateTableResponse" /> class.
        /// </summary>
        /// <param name="table">
        /// The updated table resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateTableResponse(
            global::Instill.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTableResponse" /> class.
        /// </summary>
        public UpdateTableResponse()
        {
        }
    }
}