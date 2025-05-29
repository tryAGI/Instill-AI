
#nullable enable

namespace Instill
{
    /// <summary>
    /// Folder represents a folder resource.
    /// </summary>
    public sealed partial class Folder
    {
        /// <summary>
        /// The unique identifier of the folder.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The name of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional metadata associated with the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The timestamp when the folder was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// The timestamp when the folder was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The ID of the catalog that this folder is bound to.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogId")]
        public string? CatalogId { get; set; }

        /// <summary>
        /// Permission defines how a folder can be used.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::Instill.FolderPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the folder.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The name of the folder.
        /// </param>
        /// <param name="description">
        /// A description of the folder.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the folder.
        /// </param>
        /// <param name="createTime">
        /// The timestamp when the folder was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// The timestamp when the folder was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="catalogId">
        /// The ID of the catalog that this folder is bound to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="permission">
        /// Permission defines how a folder can be used.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Folder(
            string name,
            string? uid,
            string? description,
            object? metadata,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? catalogId,
            global::Instill.FolderPermission? permission)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uid = uid;
            this.Description = description;
            this.Metadata = metadata;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.CatalogId = catalogId;
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        public Folder()
        {
        }
    }
}