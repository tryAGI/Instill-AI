
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateFolderResponse contains the created folder.
    /// </summary>
    public sealed partial class CreateFolderResponse
    {
        /// <summary>
        /// The created folder resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        public global::Instill.Folder? Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderResponse" /> class.
        /// </summary>
        /// <param name="folder">
        /// The created folder resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFolderResponse(
            global::Instill.Folder? folder)
        {
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderResponse" /> class.
        /// </summary>
        public CreateFolderResponse()
        {
        }
    }
}