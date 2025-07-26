
#nullable enable

namespace Instill
{
    /// <summary>
    /// GetFolderFileResponse represents a response for getting a folder file.
    /// </summary>
    public sealed partial class GetFolderFileResponse
    {
        /// <summary>
        /// The file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::Instill.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolderFileResponse" /> class.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFolderFileResponse(
            global::Instill.File? file)
        {
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolderFileResponse" /> class.
        /// </summary>
        public GetFolderFileResponse()
        {
        }
    }
}