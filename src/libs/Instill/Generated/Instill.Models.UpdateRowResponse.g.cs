
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateRowResponse contains the updated row.
    /// </summary>
    public sealed partial class UpdateRowResponse
    {
        /// <summary>
        /// The updated row resource.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateRowResponse" /> class.
        /// </summary>
        /// <param name="row">
        /// The updated row resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateRowResponse(
            global::Instill.Row? row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRowResponse" /> class.
        /// </summary>
        public UpdateRowResponse()
        {
        }
    }
}