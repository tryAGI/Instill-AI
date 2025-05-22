
#nullable enable

namespace Instill
{
    /// <summary>
    /// TableTemplate represents a table template.<br/>
    /// GetTableTemplateResponse contains the requested table template.
    /// </summary>
    public sealed partial class GetTableTemplateResponse
    {
        /// <summary>
        /// The table template.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableTemplate")]
        public global::Instill.Table? TableTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableTemplateResponse" /> class.
        /// </summary>
        /// <param name="tableTemplate">
        /// The table template.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTableTemplateResponse(
            global::Instill.Table? tableTemplate)
        {
            this.TableTemplate = tableTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableTemplateResponse" /> class.
        /// </summary>
        public GetTableTemplateResponse()
        {
        }
    }
}