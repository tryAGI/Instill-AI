
#nullable enable

namespace Instill
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFolderFileResponse
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderFileResponse" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// The file uid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFolderFileResponse(
            string? fileUid)
        {
            this.FileUid = fileUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFolderFileResponse" /> class.
        /// </summary>
        public DeleteFolderFileResponse()
        {
        }
    }
}