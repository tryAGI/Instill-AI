
#nullable enable

namespace Instill
{
    /// <summary>
    /// ListTableTemplatesResponse contains the list of table templates.
    /// </summary>
    public sealed partial class ListTableTemplatesResponse
    {
        /// <summary>
        /// The list of table templates.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableTemplates")]
        public global::System.Collections.Generic.IList<global::Instill.Table>? TableTemplates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableTemplatesResponse" /> class.
        /// </summary>
        /// <param name="tableTemplates">
        /// The list of table templates.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTableTemplatesResponse(
            global::System.Collections.Generic.IList<global::Instill.Table>? tableTemplates)
        {
            this.TableTemplates = tableTemplates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTableTemplatesResponse" /> class.
        /// </summary>
        public ListTableTemplatesResponse()
        {
        }
    }
}