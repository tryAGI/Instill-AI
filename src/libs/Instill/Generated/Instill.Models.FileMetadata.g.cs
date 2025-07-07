
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileMetadata contains information about the file.
    /// </summary>
    public sealed partial class FileMetadata
    {
        /// <summary>
        /// File UID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File Type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileTypeJsonConverter))]
        public global::Instill.FileType? FileType { get; set; }

        /// <summary>
        /// Size.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Processing status of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata" /> class.
        /// </summary>
        /// <param name="uid">
        /// File UID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="filename">
        /// Included only in responses
        /// </param>
        /// <param name="fileType">
        /// File Type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// Size.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="processStatus">
        /// Processing status of the file.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileMetadata(
            string? uid,
            string? filename,
            global::Instill.FileType? fileType,
            string? size,
            global::System.DateTime? createTime,
            global::Instill.FileProcessStatus? processStatus)
        {
            this.Uid = uid;
            this.Filename = filename;
            this.FileType = fileType;
            this.Size = size;
            this.CreateTime = createTime;
            this.ProcessStatus = processStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata" /> class.
        /// </summary>
        public FileMetadata()
        {
        }
    }
}