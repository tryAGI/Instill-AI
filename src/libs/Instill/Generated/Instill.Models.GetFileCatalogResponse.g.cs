
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFileCatalogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalData")]
        public string? OriginalData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Instill.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Instill.Text? Text { get; set; }

        /// <summary>
        /// 
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
        /// <param name="originalData"></param>
        /// <param name="metadata"></param>
        /// <param name="text"></param>
        /// <param name="chunks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFileCatalogResponse(
            string? originalData,
            global::Instill.Metadata? metadata,
            global::Instill.Text? text,
            global::System.Collections.Generic.IList<global::Instill.GetFileCatalogResponseChunk>? chunks)
        {
            this.OriginalData = originalData;
            this.Metadata = metadata;
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