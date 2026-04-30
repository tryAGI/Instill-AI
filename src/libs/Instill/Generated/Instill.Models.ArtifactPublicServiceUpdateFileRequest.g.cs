
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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }

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
        /// Human-readable display name of the owner namespace.<br/>
        /// Populated server-side to avoid an extra frontend API call.<br/>
        /// Example: "Instill AI" (for an org) or "John Doe" (for a user).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerDisplayName")]
        public string? OwnerDisplayName { get; set; }

        /// <summary>
        /// Avatar URL of the owner namespace.<br/>
        /// Populated server-side alongside owner_display_name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerAvatar")]
        public string? OwnerAvatar { get; set; }

        /// <summary>
        /// Human-readable display name of the user who created this file.<br/>
        /// Populated server-side to avoid an extra frontend API call.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorDisplayName")]
        public string? CreatorDisplayName { get; set; }

        /// <summary>
        /// Avatar URL of the user who created this file.<br/>
        /// Populated server-side alongside creator_display_name.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorAvatar")]
        public string? CreatorAvatar { get; set; }

        /// <summary>
        /// Visibility of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Instill.JsonConverters.FileVisibilityJsonConverter))]
        public global::Instill.FileVisibility? Visibility { get; set; }

        /// <summary>
        /// Derived resource URI populated on `ListFiles` / `GetFile` responses when<br/>
        /// the caller requested an explicit `File.View` (SUMMARY, CONTENT,<br/>
        /// STANDARD_FILE_TYPE, ORIGINAL_FILE_TYPE, CACHE, PATCH). Mirrors the<br/>
        /// long-standing `GetFileResponse.derived_resource_uri` slot so<br/>
        /// list-shaped responses can carry per-row URIs without an extra per-file<br/>
        /// `GetFile` round trip. Empty when no view was requested. Subject to the<br/>
        /// short-lived MinIO/GCS presign TTL — treat as ephemeral and do not<br/>
        /// cross-cache.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("derivedResourceUri")]
        public string? DerivedResourceUri { get; set; }

        /// <summary>
        /// Stable, cache-friendly URL to a small (~1024px WebP) thumbnail of the<br/>
        /// file, populated whenever a `CONVERTED_FILE_TYPE_THUMBNAIL` row exists<br/>
        /// for this file. Resolved through the gateway's<br/>
        /// `/v1alpha/blob-urls/{object_uid}` route so the URL itself is stable<br/>
        /// across presign rotations and CDN-cacheable. Empty for files whose<br/>
        /// thumbnail has not yet been generated (backfill workflow covers<br/>
        /// historical rows; ingest covers new ones). Clients should treat this as<br/>
        /// the preferred card-tile source and fall back to `derived_resource_uri`<br/>
        /// / mime-type icon when absent.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnailUri")]
        public string? ThumbnailUri { get; set; }

        /// <summary>
        /// The project that this file belongs to (single parent).<br/>
        /// File permissions cascade from this project — the file inherits<br/>
        /// viewer/editor/commenter/resource_owner from its parent project.<br/>
        /// Format: `namespaces/{namespace}/projects/{project}`<br/>
        /// Populated server-side from the file's parent_project_uid DB column.<br/>
        /// Files without an explicit parent project default to the namespace's<br/>
        /// root project ("Workspace").<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentProject")]
        public string? ParentProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPublicServiceUpdateFileRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Field 3: Human-readable display name (filename) for UI.<br/>
        /// This is typically the original filename of the uploaded file.
        /// </param>
        /// <param name="id">
        /// Included only in responses
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
        /// <param name="creatorName">
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
        /// <param name="ownerDisplayName">
        /// Human-readable display name of the owner namespace.<br/>
        /// Populated server-side to avoid an extra frontend API call.<br/>
        /// Example: "Instill AI" (for an org) or "John Doe" (for a user).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownerAvatar">
        /// Avatar URL of the owner namespace.<br/>
        /// Populated server-side alongside owner_display_name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorDisplayName">
        /// Human-readable display name of the user who created this file.<br/>
        /// Populated server-side to avoid an extra frontend API call.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creatorAvatar">
        /// Avatar URL of the user who created this file.<br/>
        /// Populated server-side alongside creator_display_name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="visibility">
        /// Visibility of the file.
        /// </param>
        /// <param name="derivedResourceUri">
        /// Derived resource URI populated on `ListFiles` / `GetFile` responses when<br/>
        /// the caller requested an explicit `File.View` (SUMMARY, CONTENT,<br/>
        /// STANDARD_FILE_TYPE, ORIGINAL_FILE_TYPE, CACHE, PATCH). Mirrors the<br/>
        /// long-standing `GetFileResponse.derived_resource_uri` slot so<br/>
        /// list-shaped responses can carry per-row URIs without an extra per-file<br/>
        /// `GetFile` round trip. Empty when no view was requested. Subject to the<br/>
        /// short-lived MinIO/GCS presign TTL — treat as ephemeral and do not<br/>
        /// cross-cache.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="thumbnailUri">
        /// Stable, cache-friendly URL to a small (~1024px WebP) thumbnail of the<br/>
        /// file, populated whenever a `CONVERTED_FILE_TYPE_THUMBNAIL` row exists<br/>
        /// for this file. Resolved through the gateway's<br/>
        /// `/v1alpha/blob-urls/{object_uid}` route so the URL itself is stable<br/>
        /// across presign rotations and CDN-cacheable. Empty for files whose<br/>
        /// thumbnail has not yet been generated (backfill workflow covers<br/>
        /// historical rows; ingest covers new ones). Clients should treat this as<br/>
        /// the preferred card-tile source and fall back to `derived_resource_uri`<br/>
        /// / mime-type icon when absent.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="parentProject">
        /// The project that this file belongs to (single parent).<br/>
        /// File permissions cascade from this project — the file inherits<br/>
        /// viewer/editor/commenter/resource_owner from its parent project.<br/>
        /// Format: `namespaces/{namespace}/projects/{project}`<br/>
        /// Populated server-side from the file's parent_project_uid DB column.<br/>
        /// Files without an explicit parent project default to the namespace's<br/>
        /// root project ("Workspace").<br/>
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
            string? creatorName,
            string? content,
            string? downloadUrl,
            string? convertingPipeline,
            global::Instill.Position? length,
            global::System.Collections.Generic.IList<string>? collections,
            global::System.DateTime? deleteTime,
            string? @object,
            bool? isTextBased,
            string? contentSha256,
            string? ownerDisplayName,
            string? ownerAvatar,
            string? creatorDisplayName,
            string? creatorAvatar,
            global::Instill.FileVisibility? visibility,
            string? derivedResourceUri,
            string? thumbnailUri,
            string? parentProject)
        {
            this.Id = id;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
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
            this.CreatorName = creatorName;
            this.Content = content;
            this.DownloadUrl = downloadUrl;
            this.ConvertingPipeline = convertingPipeline;
            this.Length = length;
            this.Collections = collections;
            this.DeleteTime = deleteTime;
            this.Object = @object;
            this.IsTextBased = isTextBased;
            this.ContentSha256 = contentSha256;
            this.OwnerDisplayName = ownerDisplayName;
            this.OwnerAvatar = ownerAvatar;
            this.CreatorDisplayName = creatorDisplayName;
            this.CreatorAvatar = creatorAvatar;
            this.Visibility = visibility;
            this.DerivedResourceUri = derivedResourceUri;
            this.ThumbnailUri = thumbnailUri;
            this.ParentProject = parentProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPublicServiceUpdateFileRequest" /> class.
        /// </summary>
        public ArtifactPublicServiceUpdateFileRequest()
        {
        }
    }
}