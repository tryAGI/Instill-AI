
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateTableFromTemplateRequest represents a request to create a table from a table template.
    /// </summary>
    public sealed partial class CreateTableFromTemplateBody
    {
        /// <summary>
        /// The table resource to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Table Table { get; set; }

        /// <summary>
        /// The ID of the table namespace to create the table from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateNamespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateNamespaceId { get; set; }

        /// <summary>
        /// The ID of the table to create the table from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateTableUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateTableUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateBody" /> class.
        /// </summary>
        /// <param name="table">
        /// The table resource to create.
        /// </param>
        /// <param name="templateNamespaceId">
        /// The ID of the table namespace to create the table from.
        /// </param>
        /// <param name="templateTableUid">
        /// The ID of the table to create the table from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableFromTemplateBody(
            global::Instill.Table table,
            string templateNamespaceId,
            string templateTableUid)
        {
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
            this.TemplateNamespaceId = templateNamespaceId ?? throw new global::System.ArgumentNullException(nameof(templateNamespaceId));
            this.TemplateTableUid = templateTableUid ?? throw new global::System.ArgumentNullException(nameof(templateTableUid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateBody" /> class.
        /// </summary>
        public CreateTableFromTemplateBody()
        {
        }
    }
}