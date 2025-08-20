#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Create a file<br/>
        /// Creates a file.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            global::Instill.File request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file<br/>
        /// Creates a file.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="externalMetadata"></param>
        /// <param name="objectUid">
        /// objectUid in blob storage. user can upload to blob storage directly, then put objectUid here.<br/>
        /// then no need the base64 encoding for the file content.
        /// </param>
        /// <param name="convertingPipeline">
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension). The value<br/>
        /// identifies the pipeline release and and MUST have the format<br/>
        /// `{namespaceID}/{pipelineID}@{version}`.<br/>
        /// The pipeline recipe MUST have the following variable and output fields:<br/>
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
        /// The pipeline will be executed first, falling back to the catalog's<br/>
        /// conversion pipelines if the conversion doesn't yield a non-empty result<br/>
        /// (see the catalog creation endpoint documentation).<br/>
        /// For non-document catalog files, the conversion pipeline is deterministic<br/>
        /// (such files are typically trivial to convert and don't require a dedicated<br/>
        /// pipeline to improve the conversion performance).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.UploadCatalogFileResponse> UploadCatalogFileAsync(
            string namespaceId,
            string catalogId,
            string? name = default,
            global::Instill.FileType? type = default,
            string? content = default,
            object? externalMetadata = default,
            string? objectUid = default,
            string? convertingPipeline = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}