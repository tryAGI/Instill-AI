
#nullable enable

namespace Instill
{
    /// <summary>
    /// FolderOption represents a folder option.
    /// </summary>
    public sealed partial class FolderOption
    {
        /// <summary>
        /// The UID of the folder.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderUid")]
        public string? FolderUid { get; set; }

        /// <summary>
        /// The name of the folder.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The folder description.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The UIDs of the files in the folder.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileOptions")]
        public global::System.Collections.Generic.IList<global::Instill.FileOption>? FileOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderOption" /> class.
        /// </summary>
        /// <param name="folderUid">
        /// The UID of the folder.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The name of the folder.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// The folder description.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileOptions">
        /// The UIDs of the files in the folder.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderOption(
            string? folderUid,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::Instill.FileOption>? fileOptions)
        {
            this.FolderUid = folderUid;
            this.Name = name;
            this.Description = description;
            this.FileOptions = fileOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderOption" /> class.
        /// </summary>
        public FolderOption()
        {
        }
    }
}