
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateTableFromTemplateRequest represents a request to create a table from a table template.
    /// </summary>
    public sealed partial class CreateTableFromTemplateBody
    {
        /// <summary>
        /// The UID of the table template to create the table from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tableTemplateUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableTemplateUid { get; set; }

        /// <summary>
        /// The title of the table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateBody" /> class.
        /// </summary>
        /// <param name="tableTemplateUid">
        /// The UID of the table template to create the table from.
        /// </param>
        /// <param name="title">
        /// The title of the table.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTableFromTemplateBody(
            string tableTemplateUid,
            string title)
        {
            this.TableTemplateUid = tableTemplateUid ?? throw new global::System.ArgumentNullException(nameof(tableTemplateUid));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableFromTemplateBody" /> class.
        /// </summary>
        public CreateTableFromTemplateBody()
        {
        }
    }
}