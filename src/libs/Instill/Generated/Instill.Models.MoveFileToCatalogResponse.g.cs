
#nullable enable

namespace Instill
{
    /// <summary>
    /// MoveFileToCatalogResponse represents a response for moving a file to another catalog.
    /// </summary>
    public sealed partial class MoveFileToCatalogResponse
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
        /// Initializes a new instance of the <see cref="MoveFileToCatalogResponse" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// The file uid.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MoveFileToCatalogResponse(
            string? fileUid)
        {
            this.FileUid = fileUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileToCatalogResponse" /> class.
        /// </summary>
        public MoveFileToCatalogResponse()
        {
        }
    }
}