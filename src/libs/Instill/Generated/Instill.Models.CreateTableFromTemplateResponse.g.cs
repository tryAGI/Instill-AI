
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateTableFromTemplateResponse contains the created table.
    /// </summary>
    public sealed partial class CreateTableFromTemplateResponse
    {
        /// <summary>
        /// The created table.<br/>
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
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateResponse" /> class.
        /// </summary>
        /// <param name="table">
        /// The created table.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableFromTemplateResponse(
            global::Instill.Table? table)
        {
            this.Table = table;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateResponse" /> class.
        /// </summary>
        public CreateTableFromTemplateResponse()
        {
        }
    }
}