
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateFolderResponse contains the updated folder.
    /// </summary>
    public sealed partial class UpdateFolderResponse
    {
        /// <summary>
        /// The updated folder resource.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateFolderResponse" /> class.
        /// </summary>
        /// <param name="folder">
        /// The updated folder resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFolderResponse(
            global::Instill.Folder? folder)
        {
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderResponse" /> class.
        /// </summary>
        public UpdateFolderResponse()
        {
        }
    }
}