
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunksSearchBody
    {
        /// <summary>
        /// Text prompt to look for similarities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Top K. Default value: 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// File name. This field is deprecated as the file ID isn't a unique<br/>
        /// identifier within a catalog. The file UID should be used, instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ContentTypeJsonConverter))]
        public global::Instill.ContentType? ContentType { get; set; }

        /// <summary>
        /// File type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileMediaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileMediaTypeJsonConverter))]
        public global::Instill.FileMediaType? FileMediaType { get; set; }

        /// <summary>
        /// File UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Text prompt to look for similarities.
        /// </param>
        /// <param name="topK">
        /// Top K. Default value: 5.
        /// </param>
        /// <param name="fileName">
        /// File name. This field is deprecated as the file ID isn't a unique<br/>
        /// identifier within a catalog. The file UID should be used, instead.
        /// </param>
        /// <param name="contentType">
        /// Content type.
        /// </param>
        /// <param name="fileMediaType">
        /// File type.
        /// </param>
        /// <param name="fileUid">
        /// File UID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunksSearchBody(
            string textPrompt,
            long? topK,
            string? fileName,
            global::Instill.ContentType? contentType,
            global::Instill.FileMediaType? fileMediaType,
            string? fileUid)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.TopK = topK;
            this.FileName = fileName;
            this.ContentType = contentType;
            this.FileMediaType = fileMediaType;
            this.FileUid = fileUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        public SimilarityChunksSearchBody()
        {
        }
    }
}