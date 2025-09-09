
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string FileUid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileTypeJsonConverter))]
        public global::Instill.FileType? Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processOutcome")]
        public string? ProcessOutcome { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalChunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalMetadata")]
        public object? ExternalMetadata { get; set; }

        /// <summary>
        /// objectUid in blob storage. user can upload to blob storage directly, then put objectUid here.<br/>
        /// then no need the base64 encoding for the file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectUid")]
        public string? ObjectUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension). The value<br/>
        /// identifies the pipeline release and and MUST have the format<br/>
        /// `{namespaceID}/{pipelineID}@{version}`.<br/>
        /// The pipeline recipe MUST have the following variable and output fields:<br/>
        /// ```yaml variable<br/>
        /// variable:<br/>
        ///   document_input:<br/>
        ///     title: document-input<br/>
        ///     description: Upload a document (PDF/DOCX/DOC/PPTX/PPT)<br/>
        ///     type: file<br/>
        /// ```<br/>
        /// ```yaml output<br/>
        /// output:<br/>
        ///  convert_result:<br/>
        ///    title: convert-result<br/>
        ///    value: ${merge-markdown-refinement.output.results[0]}<br/>
        /// ```<br/>
        /// Other variable and output fields will be ignored.<br/>
        /// The pipeline will be executed first, falling back to the catalog's<br/>
        /// conversion pipelines if the conversion doesn't yield a non-empty result<br/>
        /// (see the catalog creation endpoint documentation).<br/>
        /// For non-document catalog files, the conversion pipeline is deterministic<br/>
        /// (such files are typically trivial to convert and don't require a dedicated<br/>
        /// pipeline to improve the conversion performance).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertingPipeline")]
        public string? ConvertingPipeline { get; set; }

        /// <summary>
        /// Length of the file in the specified unit type. It is defined as a<br/>
        /// FilePosition, so it reflects the number of positions (the unit will depend<br/>
        /// on the file type) that can be accessed in the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public global::Instill.FilePosition? Length { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="processStatus">
        /// Included only in responses
        /// </param>
        /// <param name="processOutcome">
        /// Included only in responses
        /// </param>
        /// <param name="retrievable">
        /// Included only in responses
        /// </param>
        /// <param name="content"></param>
        /// <param name="ownerUid">
        /// Included only in responses
        /// </param>
        /// <param name="creatorUid">
        /// Included only in responses
        /// </param>
        /// <param name="catalogUid">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// Included only in responses
        /// </param>
        /// <param name="totalChunks">
        /// Included only in responses
        /// </param>
        /// <param name="totalTokens">
        /// Included only in responses
        /// </param>
        /// <param name="externalMetadata"></param>
        /// <param name="objectUid">
        /// objectUid in blob storage. user can upload to blob storage directly, then put objectUid here.<br/>
        /// then no need the base64 encoding for the file content.
        /// </param>
        /// <param name="summary">
        /// Included only in responses
        /// </param>
        /// <param name="downloadUrl">
        /// Included only in responses
        /// </param>
        /// <param name="convertingPipeline">
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension). The value<br/>
        /// identifies the pipeline release and and MUST have the format<br/>
        /// `{namespaceID}/{pipelineID}@{version}`.<br/>
        /// The pipeline recipe MUST have the following variable and output fields:<br/>
        /// ```yaml variable<br/>
        /// variable:<br/>
        ///   document_input:<br/>
        ///     title: document-input<br/>
        ///     description: Upload a document (PDF/DOCX/DOC/PPTX/PPT)<br/>
        ///     type: file<br/>
        /// ```<br/>
        /// ```yaml output<br/>
        /// output:<br/>
        ///  convert_result:<br/>
        ///    title: convert-result<br/>
        ///    value: ${merge-markdown-refinement.output.results[0]}<br/>
        /// ```<br/>
        /// Other variable and output fields will be ignored.<br/>
        /// The pipeline will be executed first, falling back to the catalog's<br/>
        /// conversion pipelines if the conversion doesn't yield a non-empty result<br/>
        /// (see the catalog creation endpoint documentation).<br/>
        /// For non-document catalog files, the conversion pipeline is deterministic<br/>
        /// (such files are typically trivial to convert and don't require a dedicated<br/>
        /// pipeline to improve the conversion performance).
        /// </param>
        /// <param name="length">
        /// Length of the file in the specified unit type. It is defined as a<br/>
        /// FilePosition, so it reflects the number of positions (the unit will depend<br/>
        /// on the file type) that can be accessed in the file.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string? name,
            global::Instill.FileType? type,
            global::Instill.FileProcessStatus? processStatus,
            string? processOutcome,
            bool? retrievable,
            string? content,
            string? ownerUid,
            string? creatorUid,
            string? catalogUid,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::System.DateTime? deleteTime,
            string? size,
            int? totalChunks,
            int? totalTokens,
            object? externalMetadata,
            string? objectUid,
            string? summary,
            string? downloadUrl,
            string? convertingPipeline,
            global::Instill.FilePosition? length,
            string fileUid = default!)
        {
            this.FileUid = fileUid;
            this.Name = name;
            this.Type = type;
            this.ProcessStatus = processStatus;
            this.ProcessOutcome = processOutcome;
            this.Retrievable = retrievable;
            this.Content = content;
            this.OwnerUid = ownerUid;
            this.CreatorUid = creatorUid;
            this.CatalogUid = catalogUid;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DeleteTime = deleteTime;
            this.Size = size;
            this.TotalChunks = totalChunks;
            this.TotalTokens = totalTokens;
            this.ExternalMetadata = externalMetadata;
            this.ObjectUid = objectUid;
            this.Summary = summary;
            this.DownloadUrl = downloadUrl;
            this.ConvertingPipeline = convertingPipeline;
            this.Length = length;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}