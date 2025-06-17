
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileAttachment represents the file attachment for the message.
    /// </summary>
    public sealed partial class FileAttachment
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttachment" /> class.
        /// </summary>
        /// <param name="fileName">
        /// Included only in responses
        /// </param>
        /// <param name="fileSize">
        /// Included only in responses
        /// </param>
        /// <param name="contentType">
        /// Included only in responses
        /// </param>
        /// <param name="fileExtension">
        /// Included only in responses
        /// </param>
        /// <param name="downloadUrl">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileAttachment(
            string? fileName,
            string? fileSize,
            string? contentType,
            string? fileExtension,
            string? downloadUrl)
        {
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.ContentType = contentType;
            this.FileExtension = fileExtension;
            this.DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttachment" /> class.
        /// </summary>
        public FileAttachment()
        {
        }
    }
}