
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObjectBodyObject
    {
        /// <summary>
        /// Immutable canonical resource ID (e.g., "obj-3k7m9p2w5t1").<br/>
        /// Hash-based, unique within a namespace.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Human-readable display name (user-provided filename).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

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
        /// Object creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Object update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Size in bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Content type (MIME type from Content-Type header or file extension).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Whether the file has been uploaded to storage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isUploaded")]
        public bool? IsUploaded { get; set; }

        /// <summary>
        /// Object expiration time in days.<br/>
        /// If set to 0, the object will not be deleted automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectExpireDays")]
        public int? ObjectExpireDays { get; set; }

        /// <summary>
        /// Last modified time (client-provided metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedTime")]
        public global::System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Object delete time (for soft delete). Output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Previous slugs for backward compatibility when display_name changes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectBodyObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Immutable canonical resource ID (e.g., "obj-3k7m9p2w5t1").<br/>
        /// Hash-based, unique within a namespace.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Human-readable display name (user-provided filename).
        /// </param>
        /// <param name="ownerName">
        /// Included only in responses
        /// </param>
        /// <param name="creatorName">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Object creation time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Object update time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// Size in bytes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="contentType">
        /// Content type (MIME type from Content-Type header or file extension).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="isUploaded">
        /// Whether the file has been uploaded to storage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="objectExpireDays">
        /// Object expiration time in days.<br/>
        /// If set to 0, the object will not be deleted automatically.
        /// </param>
        /// <param name="lastModifiedTime">
        /// Last modified time (client-provided metadata).
        /// </param>
        /// <param name="deleteTime">
        /// Object delete time (for soft delete). Output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="slug"></param>
        /// <param name="aliases">
        /// Previous slugs for backward compatibility when display_name changes.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObjectBodyObject(
            string? id,
            string? displayName,
            string? ownerName,
            string? creatorName,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? size,
            string? contentType,
            bool? isUploaded,
            int? objectExpireDays,
            global::System.DateTime? lastModifiedTime,
            global::System.DateTime? deleteTime,
            string? slug,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.OwnerName = ownerName;
            this.CreatorName = creatorName;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Size = size;
            this.ContentType = contentType;
            this.IsUploaded = isUploaded;
            this.ObjectExpireDays = objectExpireDays;
            this.LastModifiedTime = lastModifiedTime;
            this.DeleteTime = deleteTime;
            this.Slug = slug;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObjectBodyObject" /> class.
        /// </summary>
        public UpdateObjectBodyObject()
        {
        }
    }
}