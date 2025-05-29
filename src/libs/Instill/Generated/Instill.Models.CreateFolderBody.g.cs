
#nullable enable

namespace Instill
{
    /// <summary>
    /// CreateFolderRequest represents a request to create a folder.
    /// </summary>
    public sealed partial class CreateFolderBody
    {
        /// <summary>
        /// The folder resource to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Instill.Folder Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderBody" /> class.
        /// </summary>
        /// <param name="folder">
        /// The folder resource to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFolderBody(
            global::Instill.Folder folder)
        {
            this.Folder = folder ?? throw new global::System.ArgumentNullException(nameof(folder));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderBody" /> class.
        /// </summary>
        public CreateFolderBody()
        {
        }
    }
}