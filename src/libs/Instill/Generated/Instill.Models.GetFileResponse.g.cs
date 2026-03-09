
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetFileResponse represents a response for getting a file.
    /// </summary>
    public sealed partial class GetFileResponse
    {
        /// <summary>
        /// The file metadata (always included).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Instill.File? File { get; set; }

        /// <summary>
        /// Derived resource URI based on view and storage provider:<br/>
        /// - VIEW_SUMMARY/CONTENT/STANDARD_FILE_TYPE/ORIGINAL_FILE_TYPE:<br/>
        ///   * STORAGE_PROVIDER_MINIO (default): MinIO pre-signed URL<br/>
        ///   * STORAGE_PROVIDER_GCS: GCS signed URL (file uploaded to GCS if needed)<br/>
        /// - VIEW_CACHE: Gemini/VertexAI cache resource name (format:<br/>
        /// cacheContent/&lt;cacheId&gt;) Only populated for views that return file content.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("derivedResourceUri")]
        public string? DerivedResourceUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileResponse" /> class.
        /// </summary>
        /// <param name="file">
        /// The file metadata (always included).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="derivedResourceUri">
        /// Derived resource URI based on view and storage provider:<br/>
        /// - VIEW_SUMMARY/CONTENT/STANDARD_FILE_TYPE/ORIGINAL_FILE_TYPE:<br/>
        ///   * STORAGE_PROVIDER_MINIO (default): MinIO pre-signed URL<br/>
        ///   * STORAGE_PROVIDER_GCS: GCS signed URL (file uploaded to GCS if needed)<br/>
        /// - VIEW_CACHE: Gemini/VertexAI cache resource name (format:<br/>
        /// cacheContent/&lt;cacheId&gt;) Only populated for views that return file content.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileResponse(
            global::Instill.File? file,
            string? derivedResourceUri)
        {
            this.File = file;
            this.DerivedResourceUri = derivedResourceUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileResponse" /> class.
        /// </summary>
        public GetFileResponse()
        {
        }
    }
}