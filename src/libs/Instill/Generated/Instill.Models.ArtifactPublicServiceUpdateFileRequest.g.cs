
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactPublicServiceUpdateFileRequest
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Field 3: Human-readable display name (filename) for UI.<br/>
        /// This is typically the original filename of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Field 6: Optional description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// File type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileTypeJsonConverter))]
        public global::Instill.FileType? Type { get; set; }

        /// <summary>
        /// File process status.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileProcessStatusJsonConverter))]
        public global::Instill.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// File process outcome message.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processOutcome")]
        public string? ProcessOutcome { get; set; }

        /// <summary>
        /// File size in bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Total number of chunks created from this file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalChunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// Total number of tokens in this file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Array of tags associated with the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom metadata provided by the user during file upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalMetadata")]
        public object? ExternalMetadata { get; set; }

        /// <summary>
        /// Knowledge base resource names that this file is associated with.<br/>
        /// Format: `namespaces/{namespace}/knowledge-bases/{knowledge_base}`<br/>
        /// A file can belong to multiple knowledge bases within the same namespace.<br/>
        /// This field is populated from the file_knowledge_base junction table.<br/>
        /// Follows AIP-122 for resource name references.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBases")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBases { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        public string? OwnerName { get; set; }

        /// <summary>
        /// File owner (User or Organization).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Instill.Owner? Owner { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }

        /// <summary>
        /// The user who created this file.<br/>
        /// Populated when creator_name is present.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Instill.V1betaUser? Creator { get; set; }

        /// <summary>
        /// Base64-encoded file content for inline upload.<br/>
        /// Alternative to object field for smaller files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Pre-signed download URL for the file.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convertingPipeline")]
        public string? ConvertingPipeline { get; set; }

        /// <summary>
        /// Length of the file in the specified unit type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public global::Instill.Position? Length { get; set; }

        /// <summary>
        /// Collection resource names that this file belongs to.<br/>
        /// Format: `namespaces/{namespace}/collections/{collection}`<br/>
        /// This field is system-managed and populated from collection membership.<br/>
        /// Follows AIP-122 for resource name references.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.IList<string>? Collections { get; set; }

        /// <summary>
        /// Soft delete timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Object resource name reference for blob storage upload.<br/>
        /// Format: `namespaces/{namespace}/objects/{object}`<br/>
        /// Two upload approaches are supported:<br/>
        /// 1. Direct upload: Upload file directly to MinIO via GetObjectUploadURL,<br/>
        ///    then provide the object resource name here.<br/>
        ///    This avoids base64 encoding overhead and is preferred for large files.<br/>
        /// 2. Inline content: Provide base64-encoded file content in the 'content'<br/>
        ///    field. When object is provided, the 'content' field is ignored.<br/>
        /// Follows AIP-122 for resource name references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Whether the document contains a native text layer (true) or is<br/>
        /// image-based / scanned (false). Determined during file processing by<br/>
        /// attempting PDF text extraction. Used for visual grounding: text-based<br/>
        /// documents get precise text highlighting while image-based documents<br/>
        /// get bounding-box overlays.<br/>
        /// Only meaningful for document file types (PDF, DOCX, PPTX, etc.).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTextBased")]
        public bool? IsTextBased { get; set; }

        /// <summary>
        /// SHA256 hash of the file content for content-based deduplication.<br/>
        /// Computed at ingestion time for both inline content uploads and object<br/>
        /// reference uploads.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentSha256")]
        public string? ContentSha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPublicServiceUpdateFileRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Field 3: Human-readable display name (filename) for UI.<br/>
        /// This is typically the original filename of the uploaded file.
        /// </param>
        /// <param name="slug"></param>
        /// <param name="aliases">
        /// Field 5: Previous slugs for backward compatibility.<br/>
        /// When display_name changes, a new slug is generated and old slugs are stored<br/>
        /// here.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Field 6: Optional description.
        /// </param>
        /// <param name="createTime">
        /// Field 7: Creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Field 8: Last update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// File type.
        /// </param>
        /// <param name="processStatus">
        /// File process status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="processOutcome">
        /// File process outcome message.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// File size in bytes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalChunks">
        /// Total number of chunks created from this file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens in this file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tags">
        /// Array of tags associated with the file.
        /// </param>
        /// <param name="externalMetadata">
        /// Custom metadata provided by the user during file upload.
        /// </param>
        /// <param name="knowledgeBases">
        /// Knowledge base resource names that this file is associated with.<br/>
        /// Format: `namespaces/{namespace}/knowledge-bases/{knowledge_base}`<br/>
        /// A file can belong to multiple knowledge bases within the same namespace.<br/>
        /// This field is populated from the file_knowledge_base junction table.<br/>
        /// Follows AIP-122 for resource name references.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownerName">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// File owner (User or Organization).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorName">
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// The user who created this file.<br/>
        /// Populated when creator_name is present.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="content">
        /// Base64-encoded file content for inline upload.<br/>
        /// Alternative to object field for smaller files.
        /// </param>
        /// <param name="downloadUrl">
        /// Pre-signed download URL for the file.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="convertingPipeline">
        /// Pipeline used for converting the file to Markdown if the file is a<br/>
        /// document (i.e., a file with pdf, doc[x] or ppt[x] extension).
        /// </param>
        /// <param name="length">
        /// Length of the file in the specified unit type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="collections">
        /// Collection resource names that this file belongs to.<br/>
        /// Format: `namespaces/{namespace}/collections/{collection}`<br/>
        /// This field is system-managed and populated from collection membership.<br/>
        /// Follows AIP-122 for resource name references.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="deleteTime">
        /// Soft delete timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="object">
        /// Object resource name reference for blob storage upload.<br/>
        /// Format: `namespaces/{namespace}/objects/{object}`<br/>
        /// Two upload approaches are supported:<br/>
        /// 1. Direct upload: Upload file directly to MinIO via GetObjectUploadURL,<br/>
        ///    then provide the object resource name here.<br/>
        ///    This avoids base64 encoding overhead and is preferred for large files.<br/>
        /// 2. Inline content: Provide base64-encoded file content in the 'content'<br/>
        ///    field. When object is provided, the 'content' field is ignored.<br/>
        /// Follows AIP-122 for resource name references.
        /// </param>
        /// <param name="isTextBased">
        /// Whether the document contains a native text layer (true) or is<br/>
        /// image-based / scanned (false). Determined during file processing by<br/>
        /// attempting PDF text extraction. Used for visual grounding: text-based<br/>
        /// documents get precise text highlighting while image-based documents<br/>
        /// get bounding-box overlays.<br/>
        /// Only meaningful for document file types (PDF, DOCX, PPTX, etc.).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="contentSha256">
        /// SHA256 hash of the file content for content-based deduplication.<br/>
        /// Computed at ingestion time for both inline content uploads and object<br/>
        /// reference uploads.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactPublicServiceUpdateFileRequest(
            string displayName,
            string? id,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases,
            string? description,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            global::Instill.FileType? type,
            global::Instill.FileProcessStatus? processStatus,
            string? processOutcome,
            string? size,
            int? totalChunks,
            int? totalTokens,
            global::System.Collections.Generic.IList<string>? tags,
            object? externalMetadata,
            global::System.Collections.Generic.IList<string>? knowledgeBases,
            string? ownerName,
            global::Instill.Owner? owner,
            string? creatorName,
            global::Instill.V1betaUser? creator,
            string? content,
            string? downloadUrl,
            string? convertingPipeline,
            global::Instill.Position? length,
            global::System.Collections.Generic.IList<string>? collections,
            global::System.DateTime? deleteTime,
            string? @object,
            bool? isTextBased,
            string? contentSha256)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id;
            this.Slug = slug;
            this.Aliases = aliases;
            this.Description = description;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Type = type;
            this.ProcessStatus = processStatus;
            this.ProcessOutcome = processOutcome;
            this.Size = size;
            this.TotalChunks = totalChunks;
            this.TotalTokens = totalTokens;
            this.Tags = tags;
            this.ExternalMetadata = externalMetadata;
            this.KnowledgeBases = knowledgeBases;
            this.OwnerName = ownerName;
            this.Owner = owner;
            this.CreatorName = creatorName;
            this.Creator = creator;
            this.Content = content;
            this.DownloadUrl = downloadUrl;
            this.ConvertingPipeline = convertingPipeline;
            this.Length = length;
            this.Collections = collections;
            this.DeleteTime = deleteTime;
            this.Object = @object;
            this.IsTextBased = isTextBased;
            this.ContentSha256 = contentSha256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPublicServiceUpdateFileRequest" /> class.
        /// </summary>
        public ArtifactPublicServiceUpdateFileRequest()
        {
        }
    }
}