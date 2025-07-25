
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateCatalogRequest represents a request to update a catalog.
    /// </summary>
    public sealed partial class UpdateCatalogBody
    {
        /// <summary>
        /// The catalog description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The catalog tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Pipelines used for converting documents (i.e., files with pdf, doc[x] or<br/>
        /// ppt[x] extension) to Markdown. The strings in the list identify the<br/>
        /// pipelines and MUST have the format `{namespaceID}/{pipelineID}@{version}`.<br/>
        /// The pipeline recipes MUST have the following variable and output fields:<br/>
        /// ```yaml variable<br/>
        /// variable:<br/>
        ///   document_input:<br/>
        ///     title: document-input<br/>
        ///     description: Upload a document (PDF/DOCX/DOC/PPTX/PPT)<br/>
        ///     type: file<br/>
        /// ```<br/>
        /// ```yaml output<br/>
        /// output:<br/>
        ///  convert_result:<br/>
        ///    title: convert-result<br/>
        ///    value: ${merge-markdown-refinement.output.results[0]}<br/>
        /// ```<br/>
        /// Other variable and output fields will be ignored.<br/>
        /// The pipelines will be executed in order until one produces a successful,<br/>
        /// non-empty result.<br/>
        /// If no pipelines are provided, a default pipeline will be used. For<br/>
        /// non-document catalog files, the conversion pipeline is deterministic (such<br/>
        /// files are typically trivial to convert and don't require a dedicated<br/>
        /// pipeline to improve the conversion performance).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertingPipelines")]
        public global::System.Collections.Generic.IList<string>? ConvertingPipelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogBody" /> class.
        /// </summary>
        /// <param name="description">
        /// The catalog description.
        /// </param>
        /// <param name="tags">
        /// The catalog tags.
        /// </param>
        /// <param name="convertingPipelines">
        /// Pipelines used for converting documents (i.e., files with pdf, doc[x] or<br/>
        /// ppt[x] extension) to Markdown. The strings in the list identify the<br/>
        /// pipelines and MUST have the format `{namespaceID}/{pipelineID}@{version}`.<br/>
        /// The pipeline recipes MUST have the following variable and output fields:<br/>
        /// ```yaml variable<br/>
        /// variable:<br/>
        ///   document_input:<br/>
        ///     title: document-input<br/>
        ///     description: Upload a document (PDF/DOCX/DOC/PPTX/PPT)<br/>
        ///     type: file<br/>
        /// ```<br/>
        /// ```yaml output<br/>
        /// output:<br/>
        ///  convert_result:<br/>
        ///    title: convert-result<br/>
        ///    value: ${merge-markdown-refinement.output.results[0]}<br/>
        /// ```<br/>
        /// Other variable and output fields will be ignored.<br/>
        /// The pipelines will be executed in order until one produces a successful,<br/>
        /// non-empty result.<br/>
        /// If no pipelines are provided, a default pipeline will be used. For<br/>
        /// non-document catalog files, the conversion pipeline is deterministic (such<br/>
        /// files are typically trivial to convert and don't require a dedicated<br/>
        /// pipeline to improve the conversion performance).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCatalogBody(
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? convertingPipelines)
        {
            this.Description = description;
            this.Tags = tags;
            this.ConvertingPipelines = convertingPipelines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogBody" /> class.
        /// </summary>
        public UpdateCatalogBody()
        {
        }
    }
}