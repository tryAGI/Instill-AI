
#nullable enable

namespace Instill
{
    /// <summary>
    /// Represents specific files within a folder.
    /// </summary>
    public sealed partial class FolderFiles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderUid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        public global::System.Collections.Generic.IList<string>? FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderFiles" /> class.
        /// </summary>
        /// <param name="folderUid"></param>
        /// <param name="fileUids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderFiles(
            string folderUid,
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.FolderUid = folderUid ?? throw new global::System.ArgumentNullException(nameof(folderUid));
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderFiles" /> class.
        /// </summary>
        public FolderFiles()
        {
        }
    }
}