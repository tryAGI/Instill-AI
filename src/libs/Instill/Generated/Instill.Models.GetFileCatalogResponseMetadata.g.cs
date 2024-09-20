
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFileCatalogResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
        ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process<br/>
        ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting<br/>
        ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
        ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
        ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
        ///  - FILE_PROCESS_STATUS_FAILED: failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileProcessStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? FileProcessStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUploadTime")]
        public global::System.DateTime? FileUploadTime { get; set; }

        /// <summary>
        /// - FILE_TYPE_TEXT: text<br/>
        ///  - FILE_TYPE_PDF: PDF<br/>
        ///  - FILE_TYPE_MARKDOWN: MARKDOWN<br/>
        ///  - FILE_TYPE_PNG: PNG(not supported yet)<br/>
        ///  - FILE_TYPE_JPEG: JPEG(not supported yet)<br/>
        ///  - FILE_TYPE_JPG: JPG(not supported yet)<br/>
        ///  - FILE_TYPE_HTML: HTML<br/>
        ///  - FILE_TYPE_DOCX: DOCX<br/>
        ///  - FILE_TYPE_DOC: DOC<br/>
        ///  - FILE_TYPE_PPT: PPT<br/>
        ///  - FILE_TYPE_PPTX: PPTX<br/>
        ///  - FILE_TYPE_XLS: XLS<br/>
        ///  - FILE_TYPE_XLSX: XLSX<br/>
        ///  - FILE_TYPE_CSV: CSV
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileTypeJsonConverter))]
        public global::Instill.FileType? FileType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}