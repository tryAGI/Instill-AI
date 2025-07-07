
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetFileCatalogResponse contains the processing outputs of a file in a<br/>
    /// catalog.
    /// </summary>
    public sealed partial class GetFileCatalogResponse
    {
        /// <summary>
        /// Base-64 representation of the original file contents.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalData")]
        public string? OriginalData { get; set; }

        /// <summary>
        /// File metadata.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileMetadata")]
        public global::Instill.FileMetadata? FileMetadata { get; set; }

        /// <summary>
        /// Converted text.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Instill.Text? Text { get; set; }

        /// <summary>
        /// Chunks.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::Instill.GetFileCatalogResponseChunk>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponse" /> class.
        /// </summary>
        /// <param name="originalData">
        /// Base-64 representation of the original file contents.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileMetadata">
        /// File metadata.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="text">
        /// Converted text.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="chunks">
        /// Chunks.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileCatalogResponse(
            string? originalData,
            global::Instill.FileMetadata? fileMetadata,
            global::Instill.Text? text,
            global::System.Collections.Generic.IList<global::Instill.GetFileCatalogResponseChunk>? chunks)
        {
            this.OriginalData = originalData;
            this.FileMetadata = fileMetadata;
            this.Text = text;
            this.Chunks = chunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFileCatalogResponse" /> class.
        /// </summary>
        public GetFileCatalogResponse()
        {
        }
    }
}