
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarityChunksSearchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public long? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.ContentTypeJsonConverter))]
        public global::Instill.ContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileMediaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileMediaTypeJsonConverter))]
        public global::Instill.FileMediaType? FileMediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        /// <param name="textPrompt"></param>
        /// <param name="topK"></param>
        /// <param name="fileName"></param>
        /// <param name="contentType"></param>
        /// <param name="fileMediaType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarityChunksSearchBody(
            string textPrompt,
            long? topK,
            string? fileName,
            global::Instill.ContentType? contentType,
            global::Instill.FileMediaType? fileMediaType)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.TopK = topK;
            this.FileName = fileName;
            this.ContentType = contentType;
            this.FileMediaType = fileMediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityChunksSearchBody" /> class.
        /// </summary>
        public SimilarityChunksSearchBody()
        {
        }
    }
}