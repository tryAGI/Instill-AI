
#nullable enable

namespace Instill
{
    /// <summary>
    /// InsertRowResponse contains the inserted row.
    /// </summary>
    public sealed partial class InsertRowResponse
    {
        /// <summary>
        /// The inserted row resource.<br/>
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
        /// Initializes a new instance of the <see cref="InsertRowResponse" /> class.
        /// </summary>
        /// <param name="row">
        /// The inserted row resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsertRowResponse(
            global::Instill.Row? row)
        {
            this.Row = row;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertRowResponse" /> class.
        /// </summary>
        public InsertRowResponse()
        {
        }
    }
}