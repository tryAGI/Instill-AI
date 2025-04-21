
#nullable enable

namespace Instill
{
    /// <summary>
    /// DocumentCell represents a cell with a document resource.
    /// </summary>
    public sealed partial class DocumentCell
    {
        /// <summary>
        /// The namespace of the document resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// The File UID of the document resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileUid { get; set; }

        /// <summary>
        /// The UID of the raw object that the document resource belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// MIME type of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCell" /> class.
        /// </summary>
        /// <param name="namespace">
        /// The namespace of the document resource.
        /// </param>
        /// <param name="fileUid">
        /// The File UID of the document resource.
        /// </param>
        /// <param name="objectUid">
        /// The UID of the raw object that the document resource belongs to.
        /// </param>
        /// <param name="name"></param>
        /// <param name="mimeType">
        /// MIME type of the document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentCell(
            string @namespace,
            string fileUid,
            string objectUid,
            string name,
            string mimeType)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.FileUid = fileUid ?? throw new global::System.ArgumentNullException(nameof(fileUid));
            this.ObjectUid = objectUid ?? throw new global::System.ArgumentNullException(nameof(objectUid));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCell" /> class.
        /// </summary>
        public DocumentCell()
        {
        }
    }
}