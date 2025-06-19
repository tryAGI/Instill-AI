
#nullable enable

namespace Instill
{
    /// <summary>
    /// Represents a folder.
    /// </summary>
    public sealed partial class ChatContextFolder
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
        /// Initializes a new instance of the <see cref="ChatContextFolder" /> class.
        /// </summary>
        /// <param name="folderUid"></param>
        /// <param name="fileUids"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContextFolder(
            string folderUid,
            global::System.Collections.Generic.IList<string>? fileUids)
        {
            this.FolderUid = folderUid ?? throw new global::System.ArgumentNullException(nameof(folderUid));
            this.FileUids = fileUids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContextFolder" /> class.
        /// </summary>
        public ChatContextFolder()
        {
        }
    }
}