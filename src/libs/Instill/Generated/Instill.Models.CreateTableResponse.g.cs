
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateTableResponse contains the created table.
    /// </summary>
    public sealed partial class CreateTableResponse
    {
        /// <summary>
        /// The created table resource.<br/>
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
        /// Initializes a new instance of the <see cref="CreateTableResponse" /> class.
        /// </summary>
        /// <param name="table">
        /// The created table resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateTableResponse(
            global::Instill.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableResponse" /> class.
        /// </summary>
        public CreateTableResponse()
        {
        }
    }
}