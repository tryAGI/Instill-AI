#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Update a catalog info<br/>
        /// Updates the information of a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogResponse> UpdateCatalogAsync(
            string namespaceId,
            string catalogId,
            global::Instill.UpdateCatalogBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a catalog info<br/>
        /// Updates the information of a catalog.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UpdateCatalogResponse> UpdateCatalogAsync(
            string namespaceId,
            string catalogId,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? convertingPipelines = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}