
#nullable enable

namespace Instill
{
    /// <summary>
    /// FileCell represents a cell with a file resource.
    /// </summary>
    public sealed partial class FileCell
    {
        /// <summary>
        /// The namespace of the file resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// The File UID of the file resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// The UID of the raw object that the file resource belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// MIME type of the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// The catalog ID of the file resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// The URL of the file resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUrl")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCell" /> class.
        /// </summary>
        /// <param name="namespace">
        /// The namespace of the file resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileUid">
        /// The File UID of the file resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="objectUid">
        /// The UID of the raw object that the file resource belongs to.
        /// </param>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogId">
        /// The catalog ID of the file resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileUrl">
        /// The URL of the file resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCell(
            string objectUid,
            string? @namespace,
            string? fileUid,
            string? name,
            string? mimeType,
            string? catalogId,
            string? fileUrl)
        {
            this.ObjectUid = objectUid ?? throw new global::System.ArgumentNullException(nameof(objectUid));
            this.Namespace = @namespace;
            this.FileUid = fileUid;
            this.Name = name;
            this.MimeType = mimeType;
            this.CatalogId = catalogId;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCell" /> class.
        /// </summary>
        public FileCell()
        {
        }
    }
}