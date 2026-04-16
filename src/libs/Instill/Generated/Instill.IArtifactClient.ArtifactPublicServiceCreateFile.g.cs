#nullable enable

namespace Instill
{
    public partial interface IArtifactClient
    {
        /// <summary>
        /// Create a file<br/>
        /// Uploads and converts a file.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Instill.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateFileResponse> ArtifactPublicServiceCreateFileAsync(
            string parent,

            global::Instill.File request,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a file<br/>
        /// Uploads and converts a file.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name (filename) for UI.<br/>
        /// This is typically the original filename of the uploaded file.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="type">
        /// File type.
        /// </param>
        /// <param name="tags">
        /// Array of tags associated with the file.
        /// </param>
        /// <param name="externalMetadata">
        /// Custom metadata provided by the user during file upload.
        /// </param>
        /// <param name="content">
        /// Base64-encoded file content for inline upload.<br/>
        /// Alternative to object field for smaller files.
        /// </param>
        /// <param name="convertingPipeline">
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension).
        /// </param>
        /// <param name="object">
        /// Object resource name reference for blob storage upload.<br/>
        /// Format: `namespaces/{namespace}/objects/{object}`<br/>
        /// Two upload approaches are supported:<br/>
        /// 1. Direct upload: Upload file directly to MinIO via GetObjectUploadURL,<br/>
        ///    then provide the object resource name here.<br/>
        ///    This avoids base64 encoding overhead and is preferred for large files.<br/>
        /// 2. Inline content: Provide base64-encoded file content in the 'content'<br/>
        ///    field. When object is provided, the 'content' field is ignored.<br/>
        /// Follows AIP-122 for resource name references.
        /// </param>
        /// <param name="visibility">
        /// Visibility of the file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "INSTILL_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Instill.CreateFileResponse> ArtifactPublicServiceCreateFileAsync(
            string parent,
            string displayName,
            string? slug = default,
            string? description = default,
            global::Instill.FileType? type = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? externalMetadata = default,
            string? content = default,
            string? convertingPipeline = default,
            string? @object = default,
            global::Instill.FileVisibility? visibility = default,
            global::Instill.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}