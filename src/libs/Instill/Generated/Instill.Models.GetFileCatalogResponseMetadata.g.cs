
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileTypeJsonConverter))]
        public global::Instill.FileType? FileType { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileProcessStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? FileProcessStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}