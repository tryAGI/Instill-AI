
#nullable enable

namespace Instill
{
    /// <summary>
    /// UpdateFolderRequest represents a request to update a folder.
    /// </summary>
    public sealed partial class UpdateFolderBody
    {
        /// <summary>
        /// The folder fields that will replace the existing ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        public global::Instill.Folder? Folder { get; set; }

        /// <summary>
        /// The update mask specifies the subset of fields that should be modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateMask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdateMask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderBody" /> class.
        /// </summary>
        /// <param name="folder">
        /// The folder fields that will replace the existing ones.
        /// </param>
        /// <param name="updateMask">
        /// The update mask specifies the subset of fields that should be modified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFolderBody(
            string updateMask,
            global::Instill.Folder? folder)
        {
            this.UpdateMask = updateMask ?? throw new global::System.ArgumentNullException(nameof(updateMask));
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderBody" /> class.
        /// </summary>
        public UpdateFolderBody()
        {
        }
    }
}